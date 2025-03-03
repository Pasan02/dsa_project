using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace MY_DESKTOP_APP.Allusercontrol
{
    public partial class UC_ADD : UserControl
    {
        Function_db fn = new Function_db();
        string query;

        // Event to notify when data is added
        public event Action DataAdded;

        public UC_ADD()
        {
            InitializeComponent();
        }

        private void UC_ADD_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (txttype.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                query = $"INSERT INTO cars3(type, brand, quantity, price) VALUES('{txttype.Text}', '{txtname.Text}', {quantity}, {price})";
                fn.SetData(query);
                MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearAll();
                LoadData(); // Refresh DataGridView in UC_ADD

                DataAdded?.Invoke(); // 🔴 Notify UC_UPDATE
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            query = "SELECT * FROM cars3";
            DataSet ds = fn.getData(query);
        }

        public void clearAll()
        {
            txttype.SelectedIndex = -1;
            txtname.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void UC_ADD_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
