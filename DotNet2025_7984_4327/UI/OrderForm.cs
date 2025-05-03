using BlApi;
using BO;
using DO;

namespace UI
{
    public partial class OrderForm : Form
    {
        private static IBl s_bl = Factory.Get;
        private int CustomerId;
        Order order;
        public OrderForm(int customerId)
        {
            InitializeComponent();
            order = new Order();
            this.CustomerId = customerId;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {

                order.IsPreferredCustomer = s_bl.ICustomer.IsExists(CustomerId);
                if (!order.IsPreferredCustomer)
                {
                    helloName.Text = "לקוח מזדמן 😄";
                }
                else
                {
                    BO.Customer? customer = s_bl.ICustomer.Read(CustomerId);
                    helloName.Text = customer?.CustomerName;
                }
                RefreshProductList();
                RefreshProductInOrderList();


            }
            catch (BlGeneralException ex)
            {
                MessageBox.Show("אירעה שגיאה BL בעת שליפת הלקוח: " + ex.Message,
                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בעת שליפת הלקוח: " + ex.Message,
                                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void RefreshProductInOrderList()
        {
            try
            {
                List<ProductInOrder> productsInOrderList = order.ProductsInOrder;
                myOrder.Items.Clear();
                if (productsInOrderList.Count == 0)
                {

                    myOrder.Items.Add("     עגלת הקניות ריקה🔍\n\n");
                    return;
                }


                foreach (ProductInOrder productInOrder in productsInOrderList)
                {
                    string productInOrderDetails = productInOrder.ToString() + "\n------------------------";
                    var productInOrderDetailsLine = productInOrderDetails.Split("\n");
                    foreach (var p in productInOrderDetailsLine)
                    {
                        myOrder.Items.Add(p.ToString());
                    }
                }
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

        private void RefreshProductList(int catagory = -1)
        {
            try
            {
                List<BO.Product>? productList;
                listProduct.Items.Clear();
                if (catagory == -1)
                {
                    productList = s_bl.IProduct.ReadAll();

                }
                else
                {
                    productList = s_bl.IProduct.ReadAll(p => (int)p.Catagory == catagory);
                }
                if (productList.Count == 0)
                    listProduct.Items.Add("No Products---😣");
                productList.ForEach(product =>
                {
                    product.SaleInProducts = s_bl.IProduct.GetActiveSales(product.ProductId, order.IsPreferredCustomer);

                    string currProduct = product.ToString() + "------------------------";
                    var productLines = currProduct.Split("\n");
                    foreach (string line in productLines)
                    {
                        listProduct.Items.Add(line.ToString());
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

        private void addProductToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (codeProductToAdd.Text == "")
                {
                    MessageBox.Show("קוד מוצר אינו תקין❌");
                    return;

                }

                int productId = int.Parse(codeProductToAdd.Text);
                int quantityInOrder = int.Parse(amountToOrderProduct.Text);

                s_bl.IOrder.AddProductToOrder(order, productId, quantityInOrder);
                MessageBox.Show("איזה כייף!!! המוצר נוסף בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                codeProductToAdd.Text = "";
                amountToOrderProduct.Text = "";
                sumOrder.Text = order.OrderTotalPrice.ToString();
                RefreshProductInOrderList();
            }
            catch (BlGeneralException ex)
            {
                MessageBox.Show("אירעה שגיאה בעת הוספת המוצר להזמנה 😣: " + ex.Message,
"שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void endOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (order.ProductsInOrder.Count == 0)
                {
                    MessageBox.Show("0 פריטים הוזמנו. לא בוצעה הזמנה. 😣: ",
                    "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                s_bl.IOrder.DoOrder(order);
                MessageBox.Show(" 🚀ההזמנה הושלמה בהצלחה--- היא בדרך אלייך");
                RefreshProductList();
                myOrder.Items.Clear();
                sumOrder.Text = "";
                helloName.Text = "";
                this.Close();
            }
            catch (BO.BlGeneralException ex)
            {
                MessageBox.Show("אירעה שגיאה בעת ביצוע הההזמנה 😣: " + ex.Message,
                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void helloName_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountToOrderProduct_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deleteFromOrder_Click(object sender, EventArgs e)
        {
            try
            {
                codeProductInputTםDelete.Text = "";
                if (codeProductInputTםDelete.Text == "")
                {
                    MessageBox.Show("קוד מוצר שגוי, הזן שנית");
                    return;
                }
                int prodIdToDelete = int.Parse(codeProductInputTםDelete.Text);
                s_bl.IOrder.AddProductToOrder(order, prodIdToDelete, -1);
                MessageBox.Show("המוצר הוסר מעגלת הקניות🚮");
                sumOrder.Text = order.OrderTotalPrice.ToString();
                RefreshProductInOrderList();
            }
            catch (BlNotExistsIdException ex)
            {
                MessageBox.Show("המוצר אינו זמין בעגלת הקניות---");

            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה בעת ביצוע הסרת המוצר מהעגלת הקניות 😣: " + ex.Message,
                "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}

