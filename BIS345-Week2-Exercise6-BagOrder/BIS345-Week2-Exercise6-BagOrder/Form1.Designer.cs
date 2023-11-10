namespace BIS345_Week2_Exercise6_BagOrder
{
    partial class QuantityComboBox1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel1 = new System.Windows.Forms.Label();
            this.DescriptionLabel2 = new System.Windows.Forms.Label();
            this.EmployeeNameTextBoxLabel3 = new System.Windows.Forms.TextBox();
            this.FullNameLabel3 = new System.Windows.Forms.Label();
            this.BagListBox1 = new System.Windows.Forms.ListBox();
            this.PleaseSelectYourBagLabel5 = new System.Windows.Forms.Label();
            this.PleaseSelectYourQuantityLabel6 = new System.Windows.Forms.Label();
            this.SelectQuantityComboBox1 = new System.Windows.Forms.ComboBox();
            this.ClearButton2 = new System.Windows.Forms.Button();
            this.OrderButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel1
            // 
            this.TitleLabel1.AutoSize = true;
            this.TitleLabel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TitleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleLabel1.Location = new System.Drawing.Point(523, 43);
            this.TitleLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel1.Name = "TitleLabel1";
            this.TitleLabel1.Size = new System.Drawing.Size(918, 55);
            this.TitleLabel1.TabIndex = 0;
            this.TitleLabel1.Text = "PARTY STATE USA BAG ORDER FORM";
            this.TitleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel1.Click += new System.EventHandler(this.TitleLabel1_Click);
            // 
            // DescriptionLabel2
            // 
            this.DescriptionLabel2.AutoSize = true;
            this.DescriptionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel2.Location = new System.Drawing.Point(798, 110);
            this.DescriptionLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DescriptionLabel2.Name = "DescriptionLabel2";
            this.DescriptionLabel2.Size = new System.Drawing.Size(385, 31);
            this.DescriptionLabel2.TabIndex = 1;
            this.DescriptionLabel2.Text = "Property Of Party State USA® ";
            // 
            // EmployeeNameTextBoxLabel3
            // 
            this.EmployeeNameTextBoxLabel3.Location = new System.Drawing.Point(975, 259);
            this.EmployeeNameTextBoxLabel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmployeeNameTextBoxLabel3.MaxLength = 25;
            this.EmployeeNameTextBoxLabel3.Multiline = true;
            this.EmployeeNameTextBoxLabel3.Name = "EmployeeNameTextBoxLabel3";
            this.EmployeeNameTextBoxLabel3.Size = new System.Drawing.Size(572, 44);
            this.EmployeeNameTextBoxLabel3.TabIndex = 2;
            this.EmployeeNameTextBoxLabel3.TextChanged += new System.EventHandler(this.EmployeeNameTextBoxLabel3_TextChanged);
            // 
            // FullNameLabel3
            // 
            this.FullNameLabel3.AutoSize = true;
            this.FullNameLabel3.Location = new System.Drawing.Point(526, 259);
            this.FullNameLabel3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FullNameLabel3.Name = "FullNameLabel3";
            this.FullNameLabel3.Size = new System.Drawing.Size(363, 37);
            this.FullNameLabel3.TabIndex = 3;
            this.FullNameLabel3.Text = "Please Enter Full Name:";
            // 
            // BagListBox1
            // 
            this.BagListBox1.FormattingEnabled = true;
            this.BagListBox1.ItemHeight = 37;
            this.BagListBox1.Items.AddRange(new object[] {
            "Full Decorative",
            "Beaded",
            "Pirate Design",
            "Fringed",
            "Leather",
            "Plain"});
            this.BagListBox1.Location = new System.Drawing.Point(49, 583);
            this.BagListBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BagListBox1.Name = "BagListBox1";
            this.BagListBox1.Size = new System.Drawing.Size(732, 226);
            this.BagListBox1.TabIndex = 6;
            this.BagListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PleaseSelectYourBagLabel5
            // 
            this.PleaseSelectYourBagLabel5.AutoSize = true;
            this.PleaseSelectYourBagLabel5.Location = new System.Drawing.Point(41, 468);
            this.PleaseSelectYourBagLabel5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PleaseSelectYourBagLabel5.Name = "PleaseSelectYourBagLabel5";
            this.PleaseSelectYourBagLabel5.Size = new System.Drawing.Size(405, 37);
            this.PleaseSelectYourBagLabel5.TabIndex = 7;
            this.PleaseSelectYourBagLabel5.Text = "1. Please Select Your Bag: ";
            // 
            // PleaseSelectYourQuantityLabel6
            // 
            this.PleaseSelectYourQuantityLabel6.AutoSize = true;
            this.PleaseSelectYourQuantityLabel6.Location = new System.Drawing.Point(874, 468);
            this.PleaseSelectYourQuantityLabel6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PleaseSelectYourQuantityLabel6.Name = "PleaseSelectYourQuantityLabel6";
            this.PleaseSelectYourQuantityLabel6.Size = new System.Drawing.Size(451, 37);
            this.PleaseSelectYourQuantityLabel6.TabIndex = 8;
            this.PleaseSelectYourQuantityLabel6.Text = "2. Please Select Your Quantity";
            // 
            // SelectQuantityComboBox1
            // 
            this.SelectQuantityComboBox1.FormattingEnabled = true;
            this.SelectQuantityComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.SelectQuantityComboBox1.Location = new System.Drawing.Point(881, 583);
            this.SelectQuantityComboBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SelectQuantityComboBox1.Name = "SelectQuantityComboBox1";
            this.SelectQuantityComboBox1.Size = new System.Drawing.Size(475, 45);
            this.SelectQuantityComboBox1.TabIndex = 9;
            this.SelectQuantityComboBox1.Text = "Select Quantity";
            this.SelectQuantityComboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClearButton2
            // 
            this.ClearButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClearButton2.Location = new System.Drawing.Point(1467, 687);
            this.ClearButton2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ClearButton2.Name = "ClearButton2";
            this.ClearButton2.Size = new System.Drawing.Size(388, 122);
            this.ClearButton2.TabIndex = 11;
            this.ClearButton2.Text = "Clear";
            this.ClearButton2.UseVisualStyleBackColor = false;
            this.ClearButton2.Click += new System.EventHandler(this.ClearButton2_Click);
            // 
            // OrderButton4
            // 
            this.OrderButton4.BackColor = System.Drawing.SystemColors.Highlight;
            this.OrderButton4.Location = new System.Drawing.Point(1467, 468);
            this.OrderButton4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OrderButton4.Name = "OrderButton4";
            this.OrderButton4.Size = new System.Drawing.Size(388, 122);
            this.OrderButton4.TabIndex = 13;
            this.OrderButton4.Text = "Order";
            this.OrderButton4.UseVisualStyleBackColor = false;
            this.OrderButton4.Click += new System.EventHandler(this.OrderButton4_Click);
            // 
            // QuantityComboBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1941, 848);
            this.Controls.Add(this.OrderButton4);
            this.Controls.Add(this.ClearButton2);
            this.Controls.Add(this.SelectQuantityComboBox1);
            this.Controls.Add(this.PleaseSelectYourQuantityLabel6);
            this.Controls.Add(this.PleaseSelectYourBagLabel5);
            this.Controls.Add(this.BagListBox1);
            this.Controls.Add(this.FullNameLabel3);
            this.Controls.Add(this.EmployeeNameTextBoxLabel3);
            this.Controls.Add(this.DescriptionLabel2);
            this.Controls.Add(this.TitleLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "QuantityComboBox1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel1;
        private System.Windows.Forms.Label DescriptionLabel2;
        private System.Windows.Forms.TextBox EmployeeNameTextBoxLabel3;
        private System.Windows.Forms.Label FullNameLabel3;
        private System.Windows.Forms.ListBox BagListBox1;
        private System.Windows.Forms.Label PleaseSelectYourBagLabel5;
        private System.Windows.Forms.Label PleaseSelectYourQuantityLabel6;
        private System.Windows.Forms.ComboBox SelectQuantityComboBox1;
        private System.Windows.Forms.Button ClearButton2;
        private System.Windows.Forms.Button OrderButton4;
    }
}

