using dyanamic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MY_DESKTOP_APP
{
    public partial class Vehicleitems : Form
    {
        private static Dynamic_Array item = new Dynamic_Array();
        public Vehicleitems()
        {
            InitializeComponent();
        }

        private void Vehicleitems_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDataToGridView();
        }

        private void SetupDataGridView()
        {
            guna2DataGridView1.Columns.Clear();
            guna2DataGridView1.Columns.Add("NameColumn", "Name");
            guna2DataGridView1.Columns.Add("QuantityColumn", "Quantity");
            guna2DataGridView1.Columns.Add("PriceColumn", "Price");
        }

        private void LoadDataToGridView()
        {
            guna2DataGridView1.Rows.Clear();
            for (int i = 0; i < item.counter; i++)
            {
                Vehiclepart part = item.arr[i];
                guna2DataGridView1.Rows.Add(part.Name, part.Quantity, part.Price);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int quantity = int.Parse(txtQuantity.Text);
            double price = double.Parse(txtprice.Text);
            Vehiclepart parts = new Vehiclepart(name, quantity, price);
            int data_added = item.Add(parts);
            if (data_added > 0)
            {
                LoadDataToGridView();
                txtname.Clear();
                txtQuantity.Clear();
                txtprice.Clear();
                MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
