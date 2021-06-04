using ServiceLayer;
using ServiceLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUIPresentationLayer
{
    public partial class BrandsForm : Form
    {
        private BrandManager brandManager;
        private BrandViewModel brandViewModel;
        private BrandViewModel selectedBrandViewModel;
        int currentRowIndex = -1;

        public BrandsForm()
        {
            InitializeComponent();

            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void BrandsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codeFirstAPIDataSet.Brands' table. You can move, or remove it, as needed.
            //this.brandsTableAdapter.Fill(this.codeFirstAPIDataSet.Brands);
            brandManager = FactoryManager.CreateBrandManager();
            brandViewModel = new BrandViewModel();

            LoadData();
            //LoadDataOld();
        }

        private void LoadData()
        {
            // TODO: This line of code loads data into the 'brandsDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.codeFirstAPIDataSet.Brands);
        }

        //manial data binding
        private void LoadDataOld()
        {
            brandsDataGridView.DataSource = brandManager.ReadAll();
            brandsDataGridView.Refresh();
        }

        private void ClearGUI()
        {
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
            currentRowIndex = -1;

            nameTxtBox.Text = string.Empty;
            
            nameTxtBox.Focus();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTxtBox.Text.Length > 0)
                {
                    brandViewModel.Name = nameTxtBox.Text;
                    brandManager.Create(brandViewModel);

                    LoadData();

                    MessageBox.Show("Brand created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    brandViewModel = new BrandViewModel();

                    ClearGUI();
                }
                else
                {
                    MessageBox.Show("Enter the name of the brand!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedBrandViewModel.Name = nameTxtBox.Text;

                brandManager.Update(selectedBrandViewModel);

                LoadData();

                MessageBox.Show("Brand updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearGUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                brandManager.Delete(selectedBrandViewModel.ID);

                brandsDataGridView.Rows.RemoveAt(currentRowIndex);

                LoadData();

                ClearGUI();

                MessageBox.Show("Brand deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void brandsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRowIndex != e.RowIndex && e.RowIndex < brandsDataGridView.Rows.Count-1)
            {
                currentRowIndex = e.RowIndex;

                //Old way:
                //selectedBrandViewModel = (BrandViewModel)brandsDataGridView.CurrentRow.DataBoundItem;

                selectedBrandViewModel = new BrandViewModel();
                selectedBrandViewModel.ID = codeFirstAPIDataSet.Brands[e.RowIndex].ID;
                selectedBrandViewModel.Name = codeFirstAPIDataSet.Brands[e.RowIndex].Name;

                nameTxtBox.Text = selectedBrandViewModel.Name;

                updateBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
        }
    }
}
