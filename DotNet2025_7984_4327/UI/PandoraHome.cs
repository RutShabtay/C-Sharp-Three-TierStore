namespace UI
{
    public partial class PandoraHome : Form
    {
        public PandoraHome()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void manager_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            managerMenu.Show();
        }

        private void seller_Click(object sender, EventArgs e)
        {
            OrderToCustomer order = new OrderToCustomer();
            order.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}