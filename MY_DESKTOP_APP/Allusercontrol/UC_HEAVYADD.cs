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
                // Get data from text boxes
                string name = guna2TextBox1.Text;
                int quantity = int.Parse(txtQuantity.Text);
                double price = double.Parse(txtprice.Text);
                int year = int.Parse(txtyear.Text);

                // Create a new Vehicle object
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
            Form parentForm = this.FindForm(); // Get the parent form that contains UC_HEAVYADD

            if (parentForm != null)
            {
                parentForm.Close(); // Close the form containing this UserControl
            }

            // Form1 will automatically be shown again because we set up the FormClosed event handler
            // in the guna2Button2_Click method in Form1.cs
        }
    }
}