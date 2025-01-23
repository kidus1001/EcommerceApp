using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EcommerceApp
{
    public partial class Login_Page : UserControl
    {
        public Login_Page()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=.; Database=productTable; Trusted_Connection=True");
            using (conn)
            {
                conn.Open();
                string query = "SELECT UserID FROM registeredUsers WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Login successful!");
                    Form1.UserID = Convert.ToInt32(result);

                    Form1.button1.Show();
                    Form1.button3.Hide();
                    Form1.button4.Hide();
                    Form1.label5.Text = "User: " + textBox1.Text;
                    this.Hide();
                    Form1.panel2.Controls.Add(Form1.hp);
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
    }
}
