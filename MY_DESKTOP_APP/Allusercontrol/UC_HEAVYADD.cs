using LinkedList1;
using System;
using System.Windows.Forms;

namespace MY_DESKTOP_APP.Allusercontrol
{
    public partial class UC_HEAVYADD : UserControl
    {
        public UC_HEAVYADD()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                string name = guna2TextBox1.Text;
                int quantity = int.Parse(txtQuantity.Text);
                double price = double.Parse(txtprice.Text);
                int year = int.Parse(txtyear.Text);

                
                Vehicle vehicle1 = new Vehicle(name, quantity, year, price);

                // Use the ListManager to add the vehicle
                int data_added = ListManager.AddVehicle(vehicle1);
                if (data_added > 0)
                {
                    // Display a message box indicating success
                    MessageBox.Show("Data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Clear the input fields
                txtyear.Clear();
                txtprice.Clear();
                txtQuantity.Clear();
                guna2TextBox1.Clear();
                guna2TextBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm(); 

            if (parentForm != null)
            {
                parentForm.Close(); 
            }

            
        }
    }
}