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

namespace EcommerceApp
{
    public partial class my_cart : UserControl
    {

        public my_cart()
        {
            InitializeComponent();
        }

        public void AddProductToCart(productClass product)
        {
            bool check = false;
            foreach (DataGridViewRow x in dataGridView1.Rows)
            {
                if (x.Cells["Column5"].Value != null && x.Cells["Column5"].Value.Equals(product.Id))
                {
                    check = true;
                    int currentAmount = Convert.ToInt32(x.Cells["Column4"].Value);
                    currentAmount++;
                    x.Cells["Column4"].Value = currentAmount;
                }
            }
            if (!check)
            {
                dataGridView1.Rows.Add(product.Id, product.Name, product.Price.ToString("F2"), product.Description, 1);
                Form1.label2Num++;
                Form1.label2.Text = "(" + Form1.label2Num + ")";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Your cart is empty!");
            }
            else if (dataGridView1.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridView1.Rows.Remove(row);
                            Form1.label2Num--;
                            Form1.label2.Text = "(" + Form1.label2Num + ")";
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double totalSum = 0;
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Your cart is empty!");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        double price = Convert.ToDouble(row.Cells["Column2"].Value);
                        int amount = Convert.ToInt32(row.Cells["Column4"].Value);
                        totalSum += price * amount;
                    }
                }
                DialogResult dialogResult = MessageBox.Show("Total = " + totalSum + " Birr.\nEnter yes to order!", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Ordered successfully!");

                    SqlConnection conn = new SqlConnection("Server=.; Database=productTable; Trusted_Connection=True");
                    using (conn)
                    {
                        conn.Open();
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow)
                                continue;
                            string query = "INSERT INTO cartList (userID, productID, productName, Amount) VALUES (@one, @two, @three, @four)";
                            SqlCommand cmd = new SqlCommand(query, conn);

                            cmd.Parameters.AddWithValue("@one", Form1.UserID);
                            cmd.Parameters.AddWithValue("@two", Convert.ToInt32(row.Cells["Column5"].Value));
                            cmd.Parameters.AddWithValue("@three", row.Cells["Column1"].Value);
                            cmd.Parameters.AddWithValue("@four", Convert.ToInt32(row.Cells["Column4"].Value));

                            cmd.ExecuteNonQuery();
                        }
                    }
                    for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                    {
                        if (!dataGridView1.Rows[i].IsNewRow)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            Form1.label2Num--;
                        }
                    }
                    Form1.label2.Text = "(" + Form1.label2Num + ")";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CartHistory ch = new CartHistory();

            SqlConnection conn = new SqlConnection("Server=.; Database=productTable; Trusted_Connection=True");
            using (conn)
            {
                conn.Open();
                string query = "SELECT userID, productID, productName, Amount, CreatedDate FROM cartList WHERE userID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", Form1.UserID);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CartHistory.dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3), reader.GetDateTime(4));
                }

                ch.Show();
            }
            Form1.panel2.Controls.Clear();
            Form1.panel2.Controls.Add(ch);
        }
    }
}
