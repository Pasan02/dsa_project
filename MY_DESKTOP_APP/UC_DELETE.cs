using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DESKTOP_APP
{
    public partial class UC_DELETE : UserControl
    {
        Function_db fn3 = new Function_db();
        String query;
        public UC_DELETE()
        {
            InitializeComponent();
            LoadData();
        }

        private void UC_DELETE_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            query = "select * from cars3";
            DataSet ds = fn3.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from cars3 where brand like '" + txtSearch.Text + "%'";
            DataSet ds = fn3.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item?", "important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from cars3 where iid=" + id + "";
                fn3.SetData(query);
                MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void UC_DELETE_Enter(object sender, EventArgs e)
        {
            LoadData();
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
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    int quantity1 = Convert.ToInt32(rows[j]["quantity"]);
                    int quantity2 = Convert.ToInt32(rows[minIndex]["quantity"]);
                    if (quantity1 < quantity2)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    DataRow temp = rows[i];
                    rows[i] = rows[minIndex];
                    rows[minIndex] = temp;
                }
            }

            DataTable sortedTable = dt.Clone();
            foreach (DataRow row in rows)
            {
                sortedTable.ImportRow(row);
            }
            guna2DataGridView1.DataSource = sortedTable;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data available to sort.");
                return;
            }

            List<DataRow> rows = dt.AsEnumerable().ToList();
            int n = rows.Count;
            for (int i = 1; i < n; i++)
            {
                DataRow keyRow = rows[i];
                string keyBrand = keyRow["brand"].ToString();
                int j = i - 1;
                while (j >= 0 && string.Compare(rows[j]["brand"].ToString(), keyBrand, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    rows[j + 1] = rows[j];
                    j--;
                }
                rows[j + 1] = keyRow;
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
            LoadData(); // Reload data from the database to restore original order
        }
    }
}
