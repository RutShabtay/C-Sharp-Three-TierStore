using BO;
using DO;
using Sale = BO.Sale;

namespace UI
{
    public partial class SalesMenu : Form
    {
        private static BlApi.IBl s_bl = BlApi.Factory.Get;

        public SalesMenu()
        {
            InitializeComponent();
            Load += SalesMenu_Load;
        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale s = new BO.Sale();
                s.SaleProductId = int.Parse(idSaleProductInput.Text);
                s.RequiredQuantityForDiscount = int.Parse(minAmountSaleInput.Text);
                s.FinalPrice = int.Parse(fainalPriceInput.Text);
                s.SaleStartDate = startSaleDateInput.Value;
                s.SaleEndDate = lastSaleDateInput.Value;
                s.IsIntendedForAllCustomers = isOnlyClubInput.Checked;
                s_bl.ISale.Create(s);
                MessageBox.Show("הידד!!! המבצע נוסף בהצלחה 😉: ");

                RefreshSaleList();

                // איפוס הטופס
                idSaleInput.Text = "";
                idSaleProductInput.Text = "";
                minAmountSaleInput.Text = "";
                isOnlyClubInput.Checked = false;
                fainalPriceInput.Text = "";
                startSaleDateInput.Value = DateTime.Now;
                lastSaleDateInput.Value = DateTime.Now;
            }
            catch (BlAlreadyExistsIdException ex)
            {
                MessageBox.Show("התקבלה שגיאה : " + ex.Message,
                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("התקבלה שגיאה : " + ex.Message,
                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SalesMenu_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshSaleList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בעת שליפת המבצעים: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshSaleList(int saleId = -1)
        {
            try
            {
                List<BO.Sale>? saleList;

                salesListBox.Items.Clear();
                if (saleId == -1)
                {
                    saleList = s_bl.ISale.ReadAll();
                }
                else
                {
                    saleList = s_bl.ISale.ReadAll(s => s.SaleId == saleId);
                }
                if (saleList.Count == 0)
                    salesListBox.Items.Add("No Available Sales---😣");

                saleList.ForEach(sale =>
                {
                    string currSale = sale.ToString() + "------------------------";
                    var saleLines = currSale.Split("\n");
                    foreach (string line in saleLines)
                    {
                        salesListBox.Items.Add(line);
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

        private void filterByCodeSale_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filterByCodeSale.Text))
                {
                    RefreshSaleList();
                }
                else
                {
                    int saleId = int.Parse(filterByCodeSale.Text);
                    RefreshSaleList(saleId);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("יש להזין קוד מכירה חוקי (מספר בלבד).");
            }

        }

        private void isOnlyClubInput_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveUpdatedBtn_Click(object sender, EventArgs e)
        {

            int saleIpnputId = int.Parse(idSaleInput.Text);
            if (saleIpnputId == null)
                throw new Exception("קוד מוצר אינו תקין, אנא הזן שנית.");
            try
            {
                Sale saleToUpdate = new Sale()
                {
                    SaleId = int.Parse(idSaleInput.Text),
                    SaleProductId = int.Parse(idSalePInput.Text),
                    RequiredQuantityForDiscount = int.Parse(minAmountSaleInputUpdate.Text),
                    IsIntendedForAllCustomers = isOnlyClubInputUpdate.Checked,
                    FinalPrice = int.Parse(fainalPriceInputUpdate.Text),
                    SaleStartDate = startSaleDateInputUpdate.Value,
                    SaleEndDate = lastSaleDateInputUpdate.Value
                };
                s_bl.ISale.Update(saleToUpdate);
                RefreshSaleList();

                MessageBox.Show("המבצע עודכן בהצלחה!  🎉🎉🎉YAY", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // איפוס הטופס
                idSaleInput.Text = "";
                idSalePInput.Text = "";
                minAmountSaleInputUpdate.Value = minAmountSaleInputUpdate.Minimum;
                fainalPriceInputUpdate.Value = fainalPriceInputUpdate.Minimum;
                isOnlyClubInputUpdate.Checked = false;
                startSaleDateInputUpdate.Value = DateTime.Now;
                lastSaleDateInputUpdate.Value = DateTime.Now;

            }
            catch (BlNotExistsIdException ex)
            {

                MessageBox.Show("מצטערים 😣, המבצע אינו קיים---" + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void searchSaleBtn_Click(object sender, EventArgs e)
        {
            if (idSaleInput.Text == "")
            {
                idSalePInput.Text = "";
                minAmountSaleInputUpdate.Text = "";
                isOnlyClubInputUpdate.Checked = false;
                fainalPriceInputUpdate.Text = "";
                startSaleDateInputUpdate.Value = DateTime.Now;
                lastSaleDateInputUpdate.Value = DateTime.Now;
                return;

            }
            int saleToSearch = int.Parse(idSaleInput.Text);

            try
            {
                Sale? s = s_bl.ISale.Read(saleToSearch);
                idSalePInput.Text = Convert.ToString(s.SaleProductId);
                minAmountSaleInputUpdate.Text = Convert.ToString(s.RequiredQuantityForDiscount);
                isOnlyClubInputUpdate.Checked = Convert.ToBoolean(s.IsIntendedForAllCustomers);
                fainalPriceInputUpdate.Text = Convert.ToString(s.FinalPrice);
                startSaleDateInputUpdate.Value = Convert.ToDateTime(s.SaleStartDate);
                lastSaleDateInputUpdate.Value = Convert.ToDateTime(s.SaleEndDate);

            }
            catch (BlNotExistsIdException ex)
            {

                MessageBox.Show("מצטערים 😣, המבצע אינו קיים---" + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int saleToDelete = int.Parse(codeSaleInputToDelete.Text);
                s_bl.ISale.Delete(saleToDelete);
                MessageBox.Show("המבצע הוסר בהצלחה !!!YAY🎉🎉🎉", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codeSaleInputToDelete.Text = "";
                RefreshSaleList();
            }
            catch (BlNotExistsIdException ex)
            {

                MessageBox.Show("מצטערים 😣, המבצע אינו קיים---" + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("התקבלה שגיאה: " + ex.Message,
                                   "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void showDetailsSale_Click(object sender, EventArgs e)
        {
            try
            {
                int saleId = int.Parse(codeSaleInputSearch.Text);
                Sale? sale = s_bl.ISale.Read(saleId);
                if (saleDetails != null)
                {
                    string saleDetails = sale.ToString();
                    var saleDetailsLine = saleDetails.Split("\n");
                    detailsSale.Items.Add("-----פרטי מבצע👇-----\n");
                    foreach (string s in saleDetailsLine)
                    {
                        detailsSale.Items.Add(s);
                    }
                    codeSaleInputSearch.Text = "";
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

        private void detailsSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

