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
            this.PayRollExportSectionButton = new System.Windows.Forms.Button();
            this.PayRollCalculationClearButton = new System.Windows.Forms.Button();
            this.EnterFullNameTextBox = new System.Windows.Forms.TextBox();
            this.EnterEmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EnterPayrateTextbox = new System.Windows.Forms.TextBox();
            this.EnterHoursWorkedTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TotalPayTextBox = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(45, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payroll Calculation Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Employee ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Payrate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Number Of Hours Worked:";
            // 
            // PayRollCalculationSectionButton
            // 
            this.PayRollCalculationSectionButton.Location = new System.Drawing.Point(181, 576);
            this.PayRollCalculationSectionButton.Name = "PayRollCalculationSectionButton";
            this.PayRollCalculationSectionButton.Size = new System.Drawing.Size(186, 56);
            this.PayRollCalculationSectionButton.TabIndex = 6;
            this.PayRollCalculationSectionButton.Text = "Calculate";
            this.PayRollCalculationSectionButton.UseVisualStyleBackColor = true;
            this.PayRollCalculationSectionButton.Click += new System.EventHandler(this.PayRollCalculationSectionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 722);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Pay:";
            // 
            // PayRollExportSectionButton
            // 
            this.PayRollExportSectionButton.Location = new System.Drawing.Point(46, 809);
            this.PayRollExportSectionButton.Name = "PayRollExportSectionButton";
            this.PayRollExportSectionButton.Size = new System.Drawing.Size(186, 56);
            this.PayRollExportSectionButton.TabIndex = 8;
            this.PayRollExportSectionButton.Text = "Export";
            this.PayRollExportSectionButton.UseVisualStyleBackColor = true;
            this.PayRollExportSectionButton.Click += new System.EventHandler(this.PayRollExportSectionButton_Click);
            // 
            // PayRollCalculationClearButton
            // 
            this.PayRollCalculationClearButton.Location = new System.Drawing.Point(282, 809);
            this.PayRollCalculationClearButton.Name = "PayRollCalculationClearButton";
            this.PayRollCalculationClearButton.Size = new System.Drawing.Size(186, 56);
            this.PayRollCalculationClearButton.TabIndex = 9;
            this.PayRollCalculationClearButton.Text = "Clear";
            this.PayRollCalculationClearButton.UseVisualStyleBackColor = true;
            this.PayRollCalculationClearButton.Click += new System.EventHandler(this.PayRollCalculationClearButton_Click);
            // 
            // EnterFullNameTextBox
            // 
            this.EnterFullNameTextBox.Location = new System.Drawing.Point(219, 256);
            this.EnterFullNameTextBox.MaxLength = 35;
            this.EnterFullNameTextBox.Name = "EnterFullNameTextBox";
            this.EnterFullNameTextBox.Size = new System.Drawing.Size(179, 31);
            this.EnterFullNameTextBox.TabIndex = 10;
            // 
            // EnterEmployeeIDTextBox
            // 
            this.EnterEmployeeIDTextBox.Location = new System.Drawing.Point(243, 328);
            this.EnterEmployeeIDTextBox.MaxLength = 6;
            this.EnterEmployeeIDTextBox.Name = "EnterEmployeeIDTextBox";
            this.EnterEmployeeIDTextBox.Size = new System.Drawing.Size(179, 31);
            this.EnterEmployeeIDTextBox.TabIndex = 11;
            // 
            // EnterPayrateTextbox
            // 
            this.EnterPayrateTextbox.Location = new System.Drawing.Point(196, 409);
            this.EnterPayrateTextbox.MaxLength = 5;
            this.EnterPayrateTextbox.Name = "EnterPayrateTextbox";
            this.EnterPayrateTextbox.Size = new System.Drawing.Size(179, 31);
            this.EnterPayrateTextbox.TabIndex = 12;
            // 
            // EnterHoursWorkedTextbox
            // 
            this.EnterHoursWorkedTextbox.Location = new System.Drawing.Point(383, 487);
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(990, 255);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(473, 340);
            this.textBox6.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(990, 722);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 56);
            this.button4.TabIndex = 16;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1277, 722);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 56);
            this.button5.TabIndex = 17;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TotalPayTextBox
            // 
            this.TotalPayTextBox.Location = new System.Drawing.Point(161, 716);
            this.TotalPayTextBox.Name = "TotalPayTextBox";
            this.TotalPayTextBox.ReadOnly = true;
            this.TotalPayTextBox.Size = new System.Drawing.Size(179, 31);
            this.TotalPayTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1542, 900);
            this.Controls.Add(this.TotalPayTextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EnterHoursWorkedTextbox);
            this.Controls.Add(this.EnterPayrateTextbox);
            this.Controls.Add(this.EnterEmployeeIDTextBox);
            this.Controls.Add(this.EnterFullNameTextBox);
            this.Controls.Add(this.PayRollCalculationClearButton);
            this.Controls.Add(this.PayRollExportSectionButton);
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
        private System.Windows.Forms.Button PayRollExportSectionButton;
        private System.Windows.Forms.Button PayRollCalculationClearButton;
        private System.Windows.Forms.TextBox EnterFullNameTextBox;
        private System.Windows.Forms.TextBox EnterEmployeeIDTextBox;
        private System.Windows.Forms.TextBox EnterPayrateTextbox;
        private System.Windows.Forms.TextBox EnterHoursWorkedTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox TotalPayTextBox;
    }
}

