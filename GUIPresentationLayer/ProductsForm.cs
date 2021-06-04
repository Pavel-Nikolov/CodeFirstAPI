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
    public partial class ProductsForm : Form
    {
        ProductViewModel productViewModel;
        ProductViewModel selectedProductViewModel;
        ProductManager productManager;
        BrandManager brandManager;
        int currentRowIndex = -1;


        public ProductsForm()
        {
            InitializeComponent();

            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

            productManager = FactoryManager.CreateProductManager();
            brandManager = FactoryManager.CreateBrandManager();
            productViewModel = new ProductViewModel();

            LoadData();
            ClearGUI();
        }

        private void LoadData()
        {
            // TODO: This line of code loads data into the 'brandsDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.brandsDataSet.Brands);
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productsDataSet.Products);
        }

        private void ClearGUI()
        {
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

            barcodeTxtBox.Text = "";
            nameTxtBox.Text = "";
            quantityBox.Value = 0;
            priceBox.Value = 0;

            currentRowIndex = -1;

            brandListBox.SelectedIndex = -1;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateData())
                {
                    productViewModel.Barcode = barcodeTxtBox.Text;
                    productViewModel.Name = nameTxtBox.Text;
                    productViewModel.Price = priceBox.Value;
                    productViewModel.Quantity = (int)quantityBox.Value;

                    BrandViewModel brandViewModel = brandManager.Read((int)brandListBox.SelectedValue);

                    productViewModel.Brand = brandViewModel;

                    productManager.Create(productViewModel);

                    LoadData();

                    MessageBox.Show("Succesfull creation", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearGUI();

                }
                else
                {
                    MessageBox.Show("Enter data", "Not data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //(int)brandsListBox.SelectedValue;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Some error occured: {ex.Message}", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool ValidateData()
        {
            if(string.IsNullOrWhiteSpace(barcodeTxtBox.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(barcodeTxtBox.Name))
            {
                return false;
            }
            if(brandListBox.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(barcodeTxtBox.Text) || brandListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Enter data", "Not data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    selectedProductViewModel.Brand = brandManager.Read((int)brandListBox.SelectedValue);
                    selectedProductViewModel.Name = barcodeTxtBox.Text;
                    selectedProductViewModel.Price = priceBox.Value;
                    selectedProductViewModel.Quantity = (int)quantityBox.Value;

                    productManager.Update(selectedProductViewModel);

                    ClearGUI();

                    LoadData();

                    MessageBox.Show("Succesfull update", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Some error occured: {ex.Message}", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                productManager.Delete(selectedProductViewModel.Barcode);

                LoadData();

                ClearGUI();

                MessageBox.Show("Succesfull deletion", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Some error occured: {ex.Message}", "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != currentRowIndex && e.RowIndex < productsDataGridView.Rows.Count-1)
            {

                selectedProductViewModel = new ProductViewModel();

                currentRowIndex = e.RowIndex;

                selectedProductViewModel = new ProductViewModel();
                selectedProductViewModel.Barcode = productsDataSet.Products[currentRowIndex].Barcode;
                selectedProductViewModel.Name = productsDataSet.Products[currentRowIndex].Name;
                selectedProductViewModel.Quantity = productsDataSet.Products[currentRowIndex].Quantity;
                selectedProductViewModel.Price = productsDataSet.Products[currentRowIndex].Price;
                selectedProductViewModel.Brand = productManager.Read(selectedProductViewModel.Barcode).Brand;

                SetGUI();


                
            }
        }

        private void SetGUI()
        {
            barcodeTxtBox.Text = selectedProductViewModel.Barcode;
            nameTxtBox.Text = selectedProductViewModel.Name;
            priceBox.Value = selectedProductViewModel.Price;
            quantityBox.Value = selectedProductViewModel.Quantity;

            brandListBox.SelectedValue = selectedProductViewModel.Brand.ID;

            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
        }
    }
}
