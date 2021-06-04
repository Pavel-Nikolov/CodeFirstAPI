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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void brandsBtn_Click(object sender, EventArgs e)
        {
            BrandsForm brandsForm = new BrandsForm();
            brandsForm.ShowDialog();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
