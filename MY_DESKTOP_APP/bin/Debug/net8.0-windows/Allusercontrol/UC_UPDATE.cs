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
                
                query = "UPDATE cars3 SET brand='" + txtName.Text +
                        "', type='" + txtType.Text +
                        "', quantity=" + txtQuantity.Text +
                        ", price=" + txtPrice.Text +
                        " WHERE iid=" + id;

                fn2.SetData(query); 

               
                MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                LoadData("SELECT * FROM cars3");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data available to sort.");
                return;
            }

           
            List<DataRow> rows = dt.AsEnumerable().ToList();

            
            int n = rows.Count;
            //Bubble Sort Implementation-pasan's work 
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    decimal price1 = Convert.ToDecimal(rows[j]["price"]);
                    decimal price2 = Convert.ToDecimal(rows[j + 1]["price"]);

                    if (price1 > price2) 
                    {
                        DataRow temp = rows[j];
                        rows[j] = rows[j + 1];
                        rows[j + 1] = temp;
                    }
                }
            }

            
            DataTable sortedTable = dt.Clone(); 
            foreach (DataRow row in rows)
            {
                sortedTable.ImportRow(row); 
            }

            
            guna2DataGridView1.DataSource = sortedTable;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM cars3";
            LoadData(query);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard2 = new Dashboard();
            dashboard2.Show();
            this.Hide();
        }
    }
}
