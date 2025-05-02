using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            CustomersMenu customersMenu = new CustomersMenu();
            customersMenu.Show();
        }

        private void products_Click(object sender, EventArgs e)
        {
            ProductsMenu products = new ProductsMenu();
            products.Show();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            SalesMenu salesMenu = new SalesMenu();
            salesMenu.Show();
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void ManagerMenu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
