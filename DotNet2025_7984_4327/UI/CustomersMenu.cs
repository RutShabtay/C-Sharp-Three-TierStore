using BlApi;
using BO;
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
    public partial class CustomersMenu : Form
    {
        private static BlApi.IBl s_bl = BlApi.Factory.Get;

        public CustomersMenu()
        {
            InitializeComponent();
            Load += CustomersMenu_Load;
        }

        private void customersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomersMenu_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בעת שליפת הלקוחות: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCustomerList(String phone = "")
        {
            try
            {
                customersList.Items.Clear();
                List<Customer?> customerList = s_bl.ICustomer.ReadAll(c => c.CustomerPhone.StartsWith(phone));
                if (customerList.Count == 0)
                    customersList.Items.Add("No Customers---😣");
                customerList.ForEach(customer =>
                {
                    string currCustomer = customer.ToString() + "------------------------";
                    var customerLines = currCustomer.Split("\n");
                    foreach (string line in customerLines)
                    {
                        customersList.Items.Add(line);
                    }

                });

            }
            catch (BlGeneralException ex)
            {
                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בעת שליפת הלקוחות: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }



        private void CustomerIdInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer();
                c.CustomerId = int.Parse(CustomerIdInput.Text);
                c.CustomerName = CustomerNameInput.Text;
                c.CustomerAddress = CustomerAddressInput.Text;
                c.CustomerPhone = CustomerTelInput.Text;
                s_bl.ICustomer.Create(c);
                MessageBox.Show("הידד!!! הלקוח נוסף בהצלחה 😉: ");
                RefreshCustomerList();
                CustomerIdInput.Text = "";
                CustomerNameInput.Text = "";
                CustomerAddressInput.Text = "";
                CustomerTelInput.Text = "";
            }
            catch (BlAlreadyExistsIdException ex)
            {
                MessageBox.Show("הינך רשום במערכת--- : " + ex.Message,
                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("התקבלה שגיאה : " + ex.Message,
                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CustomerNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // אם המשתמש מקליד תו שאינו אות או רווח, חסום את הקלט
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void searchBtnCustomerUpdate_Click(object sender, EventArgs e)
        {
            try
            {   //איפוס השדות
                nameCustomerUpdate.Text = "";
                idCustomerUpdate.Text = "";
                addressCustomerUpdate.Text = "";
                phoneCustomerUpdate.Text = "";
                if (codeCustomerInput.Text == "")
                {
                    nameCustomerUpdate.Text = "";
                    idCustomerUpdate.Text = "";
                    addressCustomerUpdate.Text = "";
                    phoneCustomerUpdate.Text = "";
                }
                else
                {
                    Customer c = s_bl.ICustomer.Read(int.Parse(codeCustomerInput.Text));
                    nameCustomerUpdate.Text = c.CustomerName;
                    idCustomerUpdate.Text = c.CustomerId.ToString();
                    addressCustomerUpdate.Text = c.CustomerAddress;
                    phoneCustomerUpdate.Text = c.CustomerPhone;

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

        private void updateBtnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer c = new Customer();
                c.CustomerName = nameCustomerUpdate.Text;
                c.CustomerAddress = addressCustomerUpdate.Text;
                c.CustomerPhone = phoneCustomerUpdate.Text;
                c.CustomerId = int.Parse(idCustomerUpdate.Text);
                s_bl.ICustomer.Update(c);
                //איפוס השדות
                nameCustomerUpdate.Text = "";
                idCustomerUpdate.Text = "";
                addressCustomerUpdate.Text = "";
                phoneCustomerUpdate.Text = "";
                codeCustomerInput.Text = "";
                RefreshCustomerList();
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

        private void deleteBtnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = int.Parse(codeCustomerInputToDelete.Text);
                s_bl.ICustomer.Delete(custId);
                codeCustomerInputToDelete.Text = "";
                MessageBox.Show("הלקוח נמחק בהצלחה!!!🎉🎉🎉");
                RefreshCustomerList();

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

        private void showDetailsCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = int.Parse(idCustomerDisplay.Text);
                Customer customer = s_bl.ICustomer.Read(custId);
                string customerDetails = customer.ToString();
                detailCustomer.Items.Add("------פרטי לקוח 👇------\n");
                var customerLines = customerDetails.Split("\n");
                foreach (string line in customerLines)
                {
                    detailCustomer.Items.Add(line);
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

        private void filterByPhone_TextChanged(object sender, EventArgs e)
        {
            string phoneNum = filterByPhone.Text;
            RefreshCustomerList(phoneNum);

        }

        private void CustomerIdInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerAddressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
