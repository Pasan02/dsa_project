using System;
using System.Collections;
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
    public partial class UC_CUSTOMERVIEW : UserControl
    {
        Function_db fn5 = new Function_db();
        string query;

        public UC_CUSTOMERVIEW()
        {
            InitializeComponent();
            LoadData("select * from people"); // Ensure data loads when control is initialized
        }

        private void UC_CUSTOMERVIEW_Load(object sender, EventArgs e)
        {
            LoadData("select * from people");
        }

        public void LoadData(string qur)
        {
            query = qur;
            DataSet ds = fn5.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_CUSTOMERVIEW_Enter(object sender, EventArgs e)
        {
            LoadData("select * from people"); // Reload data when entering the control
        }

        public void RefreshCustomerData()
        {
            LoadData("select * from people");
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete customer?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    // Get the customer ID from the clicked row
                    int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                    // Query to delete customer from the 'people' table
                    query = "DELETE FROM people WHERE iid=" + id + "";

                    // Execute the delete query
                    fn5.SetData(query);

                    // Reload the data to reflect the change
                    LoadData("SELECT * FROM people");

                    // Show "Customer deleted successfully" message
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle potential errors
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            DataTable dt = (DataTable)guna2DataGridView1.DataSource;

            
            if (dt == null || dt.Rows.Count == 0)
                return;

            
            List<string> names = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                names.Add(row["name"].ToString());  // Assuming 'name' is the column name
            }

           
            QuickSort(names, 0, names.Count - 1);

           
            DataTable sortedData = dt.Clone();  

           
            foreach (string name in names)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["name"].ToString() == name)  
                    {
                        sortedData.ImportRow(row);
                        break;
                    }
                }
            }

            
            guna2DataGridView1.DataSource = sortedData;
        }

        // Quick Sort-Avishka's work
        private void QuickSort(List<string> list, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(list, low, high);
                QuickSort(list, low, pivotIndex - 1);
                QuickSort(list, pivotIndex + 1, high);
            }
        }

        private int Partition(List<string> list, int low, int high)
        {
            string pivot = list[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (string.Compare(list[j], pivot) < 0) // Compare strings alphabetically
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, high);
            return i + 1;
        }

        private void Swap(List<string> list, int i, int j)
        {
            string temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM people"); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard2 = new Dashboard();
            dashboard2.Show();
            this.Hide();
        }
    }
}
