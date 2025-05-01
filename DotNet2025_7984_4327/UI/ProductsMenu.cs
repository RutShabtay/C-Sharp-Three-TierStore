using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;

namespace UI
{
    public partial class ProductsMenu : Form
    {
        private static BlApi.IBl s_bl = BlApi.Factory.Get;

        public ProductsMenu()
        {
            InitializeComponent();
            Load += ProductsMenu_Load;
        }

        private void filterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProductList(filterCategory.SelectedIndex);
        }

        private void productsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductsMenu_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בעת שליפת המוצרים: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RefreshProductList(int catagory = -1)
        {
            try
            {
                List<Product>? productList;
                productsList.Items.Clear();
                if (catagory == -1)
                {
                    productList = s_bl.IProduct.ReadAll();

                }
                else
                {
                    productList = s_bl.IProduct.ReadAll(p => (int)p.catagory == catagory);
                }
                if (productList.Count == 0)
                    productsList.Items.Add("No Products---😣");
                productList.ForEach(product =>
                {
                    
                    string currProduct = product.ToString() + "------------------------";
                    var productLines = currProduct.Split("\n");
                    foreach (string line in productLines)
                    {
                        productsList.Items.Add(line.ToString());
                    }

                });

            }
            catch (BO.BlGeneralException ex)
            {
                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בעת שליפת המוצרים: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.productName = nameProductInput.Text;
                p.catagory = (Catagories)Enum.Parse(typeof(Catagories), categoryInput.Text);
                p.quantityInStock = (int)amountInput.Value;
                p.productPrice = int.Parse(priceInput.Text);
                s_bl.IProduct.Create(p);
                MessageBox.Show("המוצר נוסף בהצלחה !!!YAY🎉🎉🎉", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshProductList();

                nameProductInput.Text = "";
                priceInput.Value = 0;
                amountInput.Value = 0;
                categoryInput.SelectedIndex = -1;

            }
            catch (BlAlreadyExistsIdException ex)
            {
                MessageBox.Show($"התקבלה שגיאה: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"התקבלה שגיאה: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            try
            {   //איפוס השדות

                nameProduct.Text = "";
                price.Value = 0;
                amount.Value = 0;
                categoryUpdate.SelectedIndex = -1;
                if (codeProductInput.Text == "")
                {
                    nameProduct.Text = "";
                    price.Value = 0;
                    amount.Value = 0;
                    categoryUpdate.SelectedIndex = -1;

                }
                else
                {
                    Product p = s_bl.IProduct.Read(int.Parse(codeProductInput.Text));
                    nameProduct.Text = p.productName;
                    price.Value = (int)p.productPrice;
                    amount.Value = (int)p.quantityInStock;
                    categoryUpdate.SelectedIndex = (int)p.catagory;

                }
            }
            catch (BlNotExistsIdException ex)
            {

                MessageBox.Show("מצטערים 😣, הלקוח אינו קיים---" + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product()
                {
                    productId = int.Parse(codeProductInput.Text),
                    productName = nameProduct.Text,
                    catagory = (BO.Catagories)Enum.Parse(typeof(BO.Catagories), categoryUpdate.Text),
                    quantityInStock = (int)amount.Value,
                    productPrice = int.Parse(price.Text)
                };

                s_bl.IProduct.Update(p);
                nameProduct.Text = "";
                price.Value = 0;
                amount.Value = 0;
                categoryUpdate.SelectedIndex = -1;
                codeProductInput.Text = "";

                RefreshProductList();
            }
            catch (BlNotExistsIdException ex)
            {

                MessageBox.Show("מצטערים 😣, המוצר אינו קיים---" + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int productCode = int.Parse(codeInputToDelete.Text);
                s_bl.IProduct.Delete(productCode);
                MessageBox.Show("המוצר הוסר בהצלחה !!!YAY🎉🎉🎉", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshProductList();

            }
            catch (BlNotExistsIdException ex)
            {

                MessageBox.Show("מצטערים 😣, הלקוח אינו קיים---" + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showDetailsProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int proId = int.Parse(idProductSearch.Text);
                Product prod = s_bl.IProduct.Read(proId);
                string prodDetails = prod.ToString();
                detailProductOne.Items.Add("------פרטי מוצר 👇------\n");
                var productLines = prodDetails.Split("\n");
                foreach (string line in productLines)
                {
                    detailProductOne.Items.Add(line);
                }

            }
            catch (BlNotExistsIdException ex)
            {

                MessageBox.Show("מצטערים 😣, המוצר אינו קיים---" + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void codeProductInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

