namespace BIS345_Week5_Exercise9_EmpPayroll
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PayRollCalculationSectionButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PayRollCalculationClearButton = new System.Windows.Forms.Button();
            this.EnterFullNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterEmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EnterPayrateTextbox = new System.Windows.Forms.TextBox();
            this.EnterHoursWorkedTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PayrollImportSectionTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.PayrollImportSectionClearButton = new System.Windows.Forms.Button();
            this.TotalPayTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(297, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(879, 62);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Peirce College Hourly Payroll Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payroll Calculation Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Six Digit Employee ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Payrate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Number Of Hours Worked:";
            // 
            // PayRollCalculationSectionButton
            // 
            this.PayRollCalculationSectionButton.Location = new System.Drawing.Point(41, 630);
            this.PayRollCalculationSectionButton.Name = "PayRollCalculationSectionButton";
            this.PayRollCalculationSectionButton.Size = new System.Drawing.Size(236, 56);
            this.PayRollCalculationSectionButton.TabIndex = 6;
            this.PayRollCalculationSectionButton.Text = "Calculate And Export";
            this.PayRollCalculationSectionButton.UseVisualStyleBackColor = true;
            this.PayRollCalculationSectionButton.Click += new System.EventHandler(this.PayRollCalculationSectionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 753);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Pay (Gross):";
            // 
            // PayRollCalculationClearButton
            // 
            this.PayRollCalculationClearButton.Location = new System.Drawing.Point(311, 630);
            this.PayRollCalculationClearButton.Name = "PayRollCalculationClearButton";
            this.PayRollCalculationClearButton.Size = new System.Drawing.Size(236, 56);
            this.PayRollCalculationClearButton.TabIndex = 9;
            this.PayRollCalculationClearButton.Text = "Clear";
            this.PayRollCalculationClearButton.UseVisualStyleBackColor = true;
            this.PayRollCalculationClearButton.Click += new System.EventHandler(this.PayRollCalculationClearButton_Click);
            // 
            // EnterFullNameTextBox
            // 
            this.EnterFullNameTextBox.Location = new System.Drawing.Point(219, 165);
            this.EnterFullNameTextBox.MaxLength = 35;
            this.EnterFullNameTextBox.Name = "EnterFullNameTextBox";
            this.EnterFullNameTextBox.Size = new System.Drawing.Size(179, 31);
            this.EnterFullNameTextBox.TabIndex = 10;
            // 
            // EnterEmployeeIDTextBox
            // 
            this.EnterEmployeeIDTextBox.Location = new System.Drawing.Point(323, 277);
            this.EnterEmployeeIDTextBox.MaxLength = 6;
            this.EnterEmployeeIDTextBox.MinimumSize = new System.Drawing.Size(6, 6);
            this.EnterEmployeeIDTextBox.Name = "EnterEmployeeIDTextBox";
            this.EnterEmployeeIDTextBox.Size = new System.Drawing.Size(179, 31);
            this.EnterEmployeeIDTextBox.TabIndex = 11;
            // 
            // EnterPayrateTextbox
            // 
            this.EnterPayrateTextbox.Location = new System.Drawing.Point(196, 392);
            this.EnterPayrateTextbox.MaxLength = 2;
            this.EnterPayrateTextbox.Name = "EnterPayrateTextbox";
            this.EnterPayrateTextbox.Size = new System.Drawing.Size(179, 31);
            this.EnterPayrateTextbox.TabIndex = 12;
            // 
            // EnterHoursWorkedTextbox
            // 
            this.EnterHoursWorkedTextbox.Location = new System.Drawing.Point(368, 507);
            this.EnterHoursWorkedTextbox.MaxLength = 5;
            this.EnterHoursWorkedTextbox.Name = "EnterHoursWorkedTextbox";
            this.EnterHoursWorkedTextbox.Size = new System.Drawing.Size(179, 31);
            this.EnterHoursWorkedTextbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1071, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "Payroll Import Section";
            // 
            // PayrollImportSectionTextBox
            // 
            this.PayrollImportSectionTextBox.Location = new System.Drawing.Point(990, 255);
            this.PayrollImportSectionTextBox.Multiline = true;
            this.PayrollImportSectionTextBox.Name = "PayrollImportSectionTextBox";
            this.PayrollImportSectionTextBox.ReadOnly = true;
            this.PayrollImportSectionTextBox.Size = new System.Drawing.Size(473, 340);
            this.PayrollImportSectionTextBox.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(990, 722);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 56);
            this.button4.TabIndex = 16;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PayrollImportSectionClearButton
            // 
            this.PayrollImportSectionClearButton.Location = new System.Drawing.Point(990, 818);
            this.PayrollImportSectionClearButton.Name = "PayrollImportSectionClearButton";
            this.PayrollImportSectionClearButton.Size = new System.Drawing.Size(186, 56);
            this.PayrollImportSectionClearButton.TabIndex = 17;
            this.PayrollImportSectionClearButton.Text = "Clear";
            this.PayrollImportSectionClearButton.UseVisualStyleBackColor = true;
            this.PayrollImportSectionClearButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // TotalPayTextBox
            // 
            this.TotalPayTextBox.Location = new System.Drawing.Point(238, 750);
            this.TotalPayTextBox.Name = "TotalPayTextBox";
            this.TotalPayTextBox.ReadOnly = true;
            this.TotalPayTextBox.Size = new System.Drawing.Size(309, 31);
            this.TotalPayTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(335, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Example: Jane Doe (Only Letters)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Example: 111112 (Only Numbers)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Example: 20 (Only Numbers)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(287, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Example: 40 (Only Numbers)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1214, 735);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(389, 31);
            this.textBox2.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1624, 900);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalPayTextBox);
            this.Controls.Add(this.PayrollImportSectionClearButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PayrollImportSectionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EnterHoursWorkedTextbox);
            this.Controls.Add(this.EnterPayrateTextbox);
            this.Controls.Add(this.EnterEmployeeIDTextBox);
            this.Controls.Add(this.EnterFullNameTextBox);
            this.Controls.Add(this.PayRollCalculationClearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PayRollCalculationSectionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Peirce College Hourly Payroll Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PayRollCalculationSectionButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PayRollCalculationClearButton;
        private System.Windows.Forms.TextBox EnterFullNameTextBox;
        private System.Windows.Forms.TextBox EnterEmployeeIDTextBox;
        private System.Windows.Forms.TextBox EnterPayrateTextbox;
        private System.Windows.Forms.TextBox EnterHoursWorkedTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PayrollImportSectionTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button PayrollImportSectionClearButton;
        private System.Windows.Forms.TextBox TotalPayTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
    }
}

