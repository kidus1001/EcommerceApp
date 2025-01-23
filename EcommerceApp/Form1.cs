namespace EcommerceApp
{
    public partial class Form1 : Form
    {
        public static HomePage hp;
        static Registration_Form rf;
        static Login_Page lp;
        static my_cart mc;
        static welcome_page wp;

        public Form1()
        {
            InitializeComponent();
            InitializeToolTips();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hp = new HomePage();
            lp = new Login_Page();
            mc = new my_cart();
            wp = new welcome_page();
            rf = new Registration_Form();

            hp.OnProductAdded += mc.AddProductToCart;
        }


        public void button1_Click_1(object sender, EventArgs e)
        {
            userControl(hp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl(rf);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl(lp);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userControl(mc);
        }

        private void userControl(UserControl userControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
        }

        private void InitializeToolTips()
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(pictureBox1, "My cart");
            toolTip1.SetToolTip(label1, "HiLCoE Ecommerce Application");
            toolTip1.SetToolTip(label2, "Amount of items on my cart");
            toolTip1.SetToolTip(button1, "Home page - to see the list of products");
            toolTip1.SetToolTip(button3, "Registration page");
            toolTip1.SetToolTip(button4, "Login page");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            userControl(wp);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}