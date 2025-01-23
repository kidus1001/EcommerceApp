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
using EcommerceApp.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EcommerceApp
{
    public partial class Registration_Form : UserControl
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public string username;
        private void button2_Click(object sender, EventArgs e)
        {
            registrationClass user;
            SqlConnection conn = new SqlConnection("Server=.; Database=productTable; Trusted_Connection=True");
            using (conn)
            {
                conn.Open();
                string query = "INSERT INTO registeredUsers (Username, Email, City, Password) VALUES (@Username, @Email, @City, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                cmd.Parameters.AddWithValue("@City", textBox4.Text);
                cmd.Parameters.AddWithValue("@Password", textBox3.Text);

                username = textBox1.Text;

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    MessageBox.Show("Registration successful!");
                    Form1.button1.Show();
                    Form1.button3.Hide();
                    Form1.button4.Hide();
                    Form1.label5.Text = "User: "+textBox1.Text;
                    this.Hide();
                    Form1.panel2.Controls.Add(Form1.hp);
                }
            }
            SqlConnection conn2 = new SqlConnection("Server=.; Database=productTable; Trusted_Connection=True");
            using (conn2)
            {
                conn2.Open();
                string query = "SELECT UserID FROM registeredUsers WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, conn2);

                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Form1.UserID = reader.GetInt32(0);
                }
            }
        }
    }
}
