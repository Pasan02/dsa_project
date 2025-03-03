namespace MY_DESKTOP_APP.Allusercontrol
{
    partial class UC_HEAVYVIEW
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HEAVYVIEW));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnback = new PictureBox();
            btnsetdefault = new Guna.UI2.WinForms.Guna2Button();
            btnsortyear = new Guna.UI2.WinForms.Guna2Button();
            dataview = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)btnback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Image = (Image)resources.GetObject("btnback.Image");
            btnback.Location = new Point(43, 17);
            btnback.Name = "btnback";
            btnback.Size = new Size(25, 31);
            btnback.SizeMode = PictureBoxSizeMode.StretchImage;
            btnback.TabIndex = 18;
            btnback.TabStop = false;
            btnback.Click += btnback_Click;
            // 
            // btnsetdefault
            // 
            btnsetdefault.BorderRadius = 15;
            btnsetdefault.CustomizableEdges = customizableEdges1;
            btnsetdefault.DisabledState.BorderColor = Color.DarkGray;
            btnsetdefault.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsetdefault.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsetdefault.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsetdefault.FillColor = Color.Salmon;
            btnsetdefault.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsetdefault.ForeColor = Color.White;
            btnsetdefault.Location = new Point(608, 430);
            btnsetdefault.Name = "btnsetdefault";
            btnsetdefault.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnsetdefault.Size = new Size(183, 57);
            btnsetdefault.TabIndex = 17;
            btnsetdefault.Text = "Set As Default";
            btnsetdefault.Click += btnsetdefault_Click;
            // 
            // btnsortyear
            // 
            btnsortyear.BorderRadius = 15;
            btnsortyear.CustomizableEdges = customizableEdges3;
            btnsortyear.DisabledState.BorderColor = Color.DarkGray;
            btnsortyear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsortyear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsortyear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsortyear.FillColor = Color.Salmon;
            btnsortyear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsortyear.ForeColor = Color.White;
            btnsortyear.Location = new Point(176, 430);
            btnsortyear.Name = "btnsortyear";
            btnsortyear.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnsortyear.Size = new Size(183, 57);
            btnsortyear.TabIndex = 16;
            btnsortyear.Text = "Sort By Year";
            btnsortyear.Click += btnsortyear_Click;
            // 
            // dataview
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataview.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataview.ColumnHeadersHeight = 35;
            dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataview.DefaultCellStyle = dataGridViewCellStyle3;
            dataview.GridColor = Color.FromArgb(231, 229, 255);
            dataview.Location = new Point(176, 17);
            dataview.Name = "dataview";
            dataview.RowHeadersVisible = false;
            dataview.RowHeadersWidth = 51;
            dataview.Size = new Size(615, 386);
            dataview.TabIndex = 15;
            dataview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataview.ThemeStyle.BackColor = Color.White;
            dataview.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataview.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataview.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataview.ThemeStyle.HeaderStyle.Height = 35;
            dataview.ThemeStyle.ReadOnly = false;
            dataview.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataview.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataview.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataview.ThemeStyle.RowsStyle.Height = 29;
            dataview.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataview.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataview.CellContentClick += dataview_CellContentClick;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // UC_HEAVYVIEW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnback);
            Controls.Add(btnsetdefault);
            Controls.Add(btnsortyear);
            Controls.Add(dataview);
            Name = "UC_HEAVYVIEW";
            Size = new Size(1004, 538);
            ((System.ComponentModel.ISupportInitialize)btnback).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnback;
        private Guna.UI2.WinForms.Guna2Button btnsetdefault;
        private Guna.UI2.WinForms.Guna2Button btnsortyear;
        private Guna.UI2.WinForms.Guna2DataGridView dataview;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
