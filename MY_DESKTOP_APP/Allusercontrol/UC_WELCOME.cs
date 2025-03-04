using System;
using System.Drawing;
using System.Windows.Forms;

namespace MY_DESKTOP_APP.Allusercontrol
{
    public partial class UC_WELCOME : UserControl
    {
        public UC_WELCOME()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (num == 0)
            {
                labelBanner.ForeColor = Color.Blue;
                num++;
            }
            else if (num == 1)
            {
                labelBanner.ForeColor = Color.Red;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.ForeColor = Color.Brown;
                num = 0; 
            }
        }

        private void labelBanner_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            Form1 form = new Form1();
            form.Show();

            
            Form parentForm = this.FindForm(); 
            {
                parentForm.Close(); 
            }
        }
    }
}
