using ServiceLayer;
using ServiceLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPresentationLayer
{
    public partial class UsersForm : Form
    {
        UserViewModel userViewModel;
        UserViewModel currentUser;
        int currentRow = -1;
        UserManager userManager;
        

        public UsersForm()
        {
            InitializeComponent();
            
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

            userViewModel = new UserViewModel();
            userManager = FactoryManager.CreateUserManager();            
            currentUser = new UserViewModel();
            

            LoadData();
            ClearGUI();

        }

        private void ClearGUI()
        {
            ageNud.Enabled = false;
            UpdateBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            ageChb.Checked = false;

            Nametxtbox.Text = "";
            ageNud.Value = 0;

            productsLsb.SelectedIndices.Clear();
            currentRow = -1;
        }

        private void LoadData()
        {
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.Products);
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ageChb_CheckedChanged(object sender, EventArgs e)
        {
            ageNud.Enabled = ageChb.Checked;
        }

        private void UsersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRow != e.RowIndex && e.RowIndex < UsersDgv.Rows.Count-1 && e.RowIndex > -1)
            {
                currentRow = e.RowIndex;
                
                currentUser.ID = usersDataSet.Users[currentRow].ID;
                currentUser.Name = usersDataSet.Users[currentRow].Name;
                try
                {
                    currentUser.Age = usersDataSet.Users[currentRow].Age;
                }
                catch (Exception)
                {

                    currentUser.Age = null;
                }
                
                currentUser.Products = userManager.Read(currentUser.ID).Products;

                SetGUI();
            }
        }

        private void SetGUI()
        {
            Nametxtbox.Text = currentUser.Name;
            if (currentUser.Age.HasValue)
            {
                ageChb.Checked = true;
                ageNud.Value = currentUser.Age.Value;
            }
            else
            {
                ageChb.Checked = false;
                ageNud.Value = 0;
            }

            productsLsb.SelectedIndices.Clear();

            for (int i = 0; i < productsLsb.Items.Count; i++)
            {
                string barcode = ((ProductsDataSet.ProductsRow)((DataRowView)productsLsb.Items[i]).Row).Barcode;
                if (currentUser.Products.Select(y => y.Barcode).Contains(barcode))
                {
                    productsLsb.SelectedIndices.Add(i);
                }
            }

            UpdateBtn.Enabled = true;
            DeleteBtn.Enabled = true;

            //var a = productsLsb.Items[0] as System.Data.DataRowView;
            //a.GetType();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxtbox.Text))
            {
                MessageBox.Show("Enter name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    userViewModel.Name = Nametxtbox.Text;
                    if (ageChb.Checked)
                    {
                        userViewModel.Age = (int)ageNud.Value;
                    }
                    else
                    {
                        userViewModel.Age = null;
                    }

                    userViewModel.Products = new List<ProductViewModel>();
                    foreach (var item in productsLsb.SelectedItems)
                    {
                        string barcode = ((ProductsDataSet.ProductsRow)((DataRowView)item).Row).Barcode;
                        userViewModel.Products.Add(new ProductViewModel() { Barcode = barcode });

                    }

                    userManager.Create(userViewModel);

                    ClearGUI();
                    LoadData();
                    userViewModel = new UserViewModel();

                    MessageBox.Show("Succesfull creation", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Some program error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nametxtbox.Text))
            {
                MessageBox.Show("Enter name", "Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    currentUser.Name = Nametxtbox.Text;
                    if (ageChb.Checked)
                    {
                        currentUser.Age = (int)ageNud.Value;
                    }
                    else
                    {
                        currentUser.Age = null;
                    }

                    currentUser.Products = new List<ProductViewModel>();

                    foreach (var item in productsLsb.SelectedItems)
                    {
                        string barcode = ((ProductsDataSet.ProductsRow)((DataRowView)item).Row).Barcode;
                        currentUser.Products.Add(new ProductViewModel() { Barcode = barcode });

                    }

                    userManager.Update(currentUser);

                    ClearGUI();
                    LoadData();

                    MessageBox.Show($"Update succssful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch ( Exception ex)
                {

                    MessageBox.Show($"Some program error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                userManager.Delete(currentUser.ID);
                MessageBox.Show($"Deletion succssful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearGUI();
                LoadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Some error occured: {ex.Message}", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
