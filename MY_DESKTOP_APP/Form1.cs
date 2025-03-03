using MY_DESKTOP_APP.Allusercontrol;
using System;
using System.Windows.Forms;

namespace MY_DESKTOP_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vehicleItemsButton_Click(object sender, EventArgs e)
        {
            Vehicleitems vehicleForm = new Vehicleitems();
            this.Hide();
            vehicleForm.Show();
            vehicleForm.FormClosed += (s, args) => this.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form heavyAddForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,  // Center the form on the screen
                Size = this.Size  // Set the new form's size to match the current form
            };

            UC_HEAVYADD UC = new UC_HEAVYADD { Dock = DockStyle.Fill };
            heavyAddForm.Controls.Add(UC);

            this.Hide();
            heavyAddForm.Show();

            // When the new form closes, show the previous form again
            heavyAddForm.FormClosed += (s, args) => this.Show();
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Dashboard das = new Dashboard();
            this.Hide();
            das.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form heavyViewForm = new Form
            {
                StartPosition = FormStartPosition.CenterScreen,  // Center the form on the screen
                Size = this.Size  // Set the new form's size to match the current form
            };
            UC_HEAVYVIEW UC = new UC_HEAVYVIEW { Dock = DockStyle.Fill };
            heavyViewForm.Controls.Add(UC);
            this.Hide();
            heavyViewForm.Show();
            heavyViewForm.FormClosed += (s, args) => this.Show();
        }

        private void btnpart_Click(object sender, EventArgs e)
        {
            Vehicleitems vehicleForm = new Vehicleitems();
            this.Hide();
            vehicleForm.Show();
            vehicleForm.FormClosed += (s, args) => this.Show();
        }
    }
}