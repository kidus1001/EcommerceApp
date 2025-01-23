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

namespace EcommerceApp
{
    public partial class HomePage : UserControl
    {

        public event Action<productClass> OnProductAdded;

        public HomePage()
        {
            InitializeComponent();
            List<productClass> pc = new List<productClass>();

            SqlConnection conn = new SqlConnection("Server=.; Database=productTable; Trusted_Connection=True");
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select productID, productName, productPrice, productImage, productDescription from productTable", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    productClass productClassx = new productClass();
                    productClassx.Id = reader.GetInt32(0);
                    productClassx.Name = reader.GetString(1);
                    productClassx.Price = (double)(decimal)reader.GetDecimal(2);

                    if (!reader.IsDBNull(3))
                    {
                        byte[] imageData = (byte[])reader["productImage"];
                        Image image;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            image = Image.FromStream(ms);
                        }

                        productClassx.Image = image;
                    }
                    else
                    {
                        productClassx.Image = Resources.Cart_Image;
                    }
                    productClassx.Description = reader.GetString(4);
                    pc.Add(productClassx);
                }
                reader.Close();
            }

            foreach (productClass items in pc)
            {
                Panel name = new Panel
                {
                    Size = new Size(285, 380),
                    BackColor = Color.Brown,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label label1 = new Label
                {
                    Text = items.Name,
                    Font = new Font("Serif", 14, FontStyle.Bold),
                    ForeColor = Color.Yellow,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 40,
                };

                Label label2 = new Label
                {
                    Text = $"Price: {items.Price:F2}",
                    Font = new Font("Serif", 11, FontStyle.Regular),
                    ForeColor = Color.Yellow,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30,
                };

                PictureBox picBox = new PictureBox
                {
                    Image = items.Image,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Top,
                    Height = 200,
                };

                Label label3 = new Label
                {
                    Text = $"Description: {items.Description}",
                    Font = new Font("Serif", 10, FontStyle.Italic),
                    ForeColor = Color.Yellow,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(250, 60),
                    Dock = DockStyle.Top,
                };


                Button addButton = new Button
                {
                    Text = "+",
                    Font = new Font("Serif", 15),
                    ForeColor = Color.White,
                    BackColor = Color.LightGreen,
                    Height = 40,
                    Dock = DockStyle.Bottom,
                };
               
                addButton.Click += (s, e) =>
                {
                    if (Form1.label5.Text != "")
                    {
                        MessageBox.Show($"{items.Name} added to cart!");
                        OnProductAdded?.Invoke(items);
                    }
                    else
                    {
                        MessageBox.Show("You have to first create an account to purchase!");
                    }
                };

                name.Controls.Add(addButton);
                name.Controls.Add(label3);
                name.Controls.Add(picBox);
                name.Controls.Add(label2);
                name.Controls.Add(label1);

                flowLayoutPanel2.Controls.Add(name);
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
