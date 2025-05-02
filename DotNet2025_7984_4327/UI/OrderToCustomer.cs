using BlApi;

namespace UI
{
    public partial class OrderToCustomer : Form
    {
        private static IBl s_bl = BlApi.Factory.Get;
        public OrderToCustomer()
        {
            InitializeComponent();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (inputId.Text == "")
            {
                MessageBox.Show("הזן תעודת זהות---");
                return;
            }

            OrderForm order = new OrderForm(int.Parse(inputId.Text));
            inputId.Text = "";
            order.Show();
        }

        private void OrderToCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
