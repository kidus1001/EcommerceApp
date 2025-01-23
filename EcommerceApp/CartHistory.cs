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

namespace EcommerceApp
{
    public partial class CartHistory : UserControl
    {
        public CartHistory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CartHistory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Your cart is empty!");
            }
            else {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear history?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                    {
                        if (!dataGridView1.Rows[i].IsNewRow)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                        }
                    }

                    SqlConnection conn = new SqlConnection("Server=.; Database=productTable; Trusted_Connection=True");
                    using (conn)
                    {
                        conn.Open();
                        string query = "DELETE FROM cartList WHERE userID = @userID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", Form1.UserID);
                        int num = cmd.ExecuteNonQuery();

                        if (num != -1)
                        {
                            MessageBox.Show(num + " rows affected!");
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong try again later!");
                        }

                    }
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Your cart is empty!");
            }
            else if (dataGridView1.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected row/s?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
            }
        }
    }
}
