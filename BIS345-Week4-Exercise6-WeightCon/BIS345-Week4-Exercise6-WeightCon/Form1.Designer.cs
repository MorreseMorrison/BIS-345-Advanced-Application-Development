namespace BIS345_Week4_Exercise6_WeightCon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserPoundValueEnterTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KiloGramsTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OuncesTextBox = new System.Windows.Forms.TextBox();
            this.GramsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(286, 12);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(790, 75);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.Text = "Weight Conversion Calculator";
            this.TitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter The Pound Weight Value:";
            // 
            // UserPoundValueEnterTextBox
            // 
            this.UserPoundValueEnterTextBox.Location = new System.Drawing.Point(817, 126);
            this.UserPoundValueEnterTextBox.Multiline = true;
            this.UserPoundValueEnterTextBox.Name = "UserPoundValueEnterTextBox";
            this.UserPoundValueEnterTextBox.Size = new System.Drawing.Size(154, 34);
            this.UserPoundValueEnterTextBox.TabIndex = 2;
            this.UserPoundValueEnterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ConvertButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConvertButton.Location = new System.Drawing.Point(546, 193);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(271, 64);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 833);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kilograms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 833);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ounces";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1001, 833);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grams";
            // 
            // KiloGramsTextBox
            // 
            this.KiloGramsTextBox.Location = new System.Drawing.Point(238, 861);
            this.KiloGramsTextBox.Multiline = true;
            this.KiloGramsTextBox.Name = "KiloGramsTextBox";
            this.KiloGramsTextBox.ReadOnly = true;
            this.KiloGramsTextBox.Size = new System.Drawing.Size(180, 31);
            this.KiloGramsTextBox.TabIndex = 7;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClearButton.Location = new System.Drawing.Point(546, 954);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(271, 64);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OuncesTextBox
            // 
            this.OuncesTextBox.Location = new System.Drawing.Point(578, 861);
            this.OuncesTextBox.Multiline = true;
            this.OuncesTextBox.Name = "OuncesTextBox";
            this.OuncesTextBox.ReadOnly = true;
            this.OuncesTextBox.Size = new System.Drawing.Size(180, 31);
            this.OuncesTextBox.TabIndex = 11;
            // 
            // GramsTextBox
            // 
            this.GramsTextBox.Location = new System.Drawing.Point(948, 861);
            this.GramsTextBox.Multiline = true;
            this.GramsTextBox.Name = "GramsTextBox";
            this.GramsTextBox.ReadOnly = true;
            this.GramsTextBox.Size = new System.Drawing.Size(180, 31);
            this.GramsTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1376, 1062);
            this.Controls.Add(this.GramsTextBox);
            this.Controls.Add(this.OuncesTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.KiloGramsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.UserPoundValueEnterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "Form1";
            this.Text = "Weight Conversion Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserPoundValueEnterTextBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KiloGramsTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox OuncesTextBox;
        private System.Windows.Forms.TextBox GramsTextBox;
    }
}

