using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DESKTOP_APP.Allusercontrol
{
    public partial class UC_UPDATE : UserControl
    {
        Function_db fn2 = new Function_db();
        String query;
        public UC_UPDATE()
        {
            InitializeComponent();
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string type = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string brand = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int quantity = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            decimal price = decimal.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            txtType.Text = type;
            txtName.Text = brand;
            txtQuantity.Text = quantity.ToString();
            txtPrice.Text = price.ToString();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_UPDATE_Load(object sender, EventArgs e)
        {
            query = "select * from cars3 ";
            LoadData(query);
        }

        public void LoadData(string qur)
        {
            query = qur;
            DataSet ds = fn2.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cars3 where brand like'" + txtSearchName.Text + "%'";
            LoadData(query);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Corrected SQL query
                query = "UPDATE cars3 SET brand='" + txtName.Text +
                        "', type='" + txtType.Text +
                        "', quantity=" + txtQuantity.Text +
                        ", price=" + txtPrice.Text +
                        " WHERE iid=" + id;

                fn2.SetData(query); // Execute the update query

                // Show success message
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh data after update
                LoadData("SELECT * FROM cars3");
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Get the current data from the DataGridView
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data available to sort.");
                return;
            }

            // Convert DataTable to a List of Rows for Sorting
            List<DataRow> rows = dt.AsEnumerable().ToList();

            // Bubble Sort Implementation (Sorting by 'price' column, assumed to be the 5th column)
            int n = rows.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    decimal price1 = Convert.ToDecimal(rows[j]["price"]);
                    decimal price2 = Convert.ToDecimal(rows[j + 1]["price"]);

                    if (price1 > price2) // Swap if the first price is greater than the second
                    {
                        DataRow temp = rows[j];
                        rows[j] = rows[j + 1];
                        rows[j + 1] = temp;
                    }
                }
            }

            // Reconstruct the sorted DataTable
            DataTable sortedTable = dt.Clone(); // Clone the structure
            foreach (DataRow row in rows)
            {
                sortedTable.ImportRow(row); // Add sorted rows back to the DataTable
            }

            // Update the DataGridView with the sorted data
            guna2DataGridView1.DataSource = sortedTable;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM cars3";
            LoadData(query);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard2 = new Dashboard();
            dashboard2.Show();
            this.Hide();
        }
    }
}
