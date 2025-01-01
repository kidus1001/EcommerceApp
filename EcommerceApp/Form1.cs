namespace EcommerceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(255, 192, 128);
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button4.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            userControl(hp);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registration_Form rf = new Registration_Form();
            userControl(rf);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login_Page lp = new Login_Page();
            userControl(lp);
        }


        private void userControl(UserControl userControl)
        {
            panel2.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            my_cart mc = new my_cart();
            userControl(mc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            //Tool tip not working

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.label1, "HiLCoE Ecommerce Application");
            toolTip1.SetToolTip(this.button1, "Home page - to see the list of products");
            toolTip1.SetToolTip(this.pictureBox1, "My cart");
            toolTip1.SetToolTip(this.label2, "Amount of items on my cart");
            toolTip1.SetToolTip(this.label2, "Amount of items on my cart");
        }
    }
}
