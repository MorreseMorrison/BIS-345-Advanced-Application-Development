namespace BIS324_Week1_TripCalculator
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
            this.TextBox1StarRentalsHeader = new System.Windows.Forms.TextBox();
            this.Label1EnterDestinationDescription = new System.Windows.Forms.Label();
            this.Label2EnterMilesTraveledDestination = new System.Windows.Forms.Label();
            this.TextBox2CarTypeGallonsDescription = new System.Windows.Forms.TextBox();
            this.TextBox3EnterDestination = new System.Windows.Forms.TextBox();
            this.TextBox4EnterMiles = new System.Windows.Forms.TextBox();
            this.Button1Calculate = new System.Windows.Forms.Button();
            this.Button2Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox1StarRentalsHeader
            // 
            this.TextBox1StarRentalsHeader.BackColor = System.Drawing.SystemColors.Info;
            this.TextBox1StarRentalsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1StarRentalsHeader.Location = new System.Drawing.Point(28, 50);
            this.TextBox1StarRentalsHeader.Name = "TextBox1StarRentalsHeader";
            this.TextBox1StarRentalsHeader.Size = new System.Drawing.Size(1182, 49);
            this.TextBox1StarRentalsHeader.TabIndex = 0;
            this.TextBox1StarRentalsHeader.Text = "Welcome To Star Rentals Trip Destination Calculator!";
            this.TextBox1StarRentalsHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox1StarRentalsHeader.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label1EnterDestinationDescription
            // 
            this.Label1EnterDestinationDescription.AutoSize = true;
            this.Label1EnterDestinationDescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Label1EnterDestinationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1EnterDestinationDescription.Location = new System.Drawing.Point(188, 235);
            this.Label1EnterDestinationDescription.Name = "Label1EnterDestinationDescription";
            this.Label1EnterDestinationDescription.Size = new System.Drawing.Size(483, 37);
            this.Label1EnterDestinationDescription.TabIndex = 1;
            this.Label1EnterDestinationDescription.Text = "Please Type In Your Destination:";
            this.Label1EnterDestinationDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label2EnterMilesTraveledDestination
            // 
            this.Label2EnterMilesTraveledDestination.AllowDrop = true;
            this.Label2EnterMilesTraveledDestination.AutoSize = true;
            this.Label2EnterMilesTraveledDestination.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Label2EnterMilesTraveledDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2EnterMilesTraveledDestination.Location = new System.Drawing.Point(188, 336);
            this.Label2EnterMilesTraveledDestination.Name = "Label2EnterMilesTraveledDestination";
            this.Label2EnterMilesTraveledDestination.Size = new System.Drawing.Size(421, 37);
            this.Label2EnterMilesTraveledDestination.TabIndex = 2;
            this.Label2EnterMilesTraveledDestination.Text = "Please Enter Miles Traveled:";
            this.Label2EnterMilesTraveledDestination.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextBox2CarTypeGallonsDescription
            // 
            this.TextBox2CarTypeGallonsDescription.AllowDrop = true;
            this.TextBox2CarTypeGallonsDescription.BackColor = System.Drawing.SystemColors.Info;
            this.TextBox2CarTypeGallonsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2CarTypeGallonsDescription.Location = new System.Drawing.Point(193, 124);
            this.TextBox2CarTypeGallonsDescription.Multiline = true;
            this.TextBox2CarTypeGallonsDescription.Name = "TextBox2CarTypeGallonsDescription";
            this.TextBox2CarTypeGallonsDescription.Size = new System.Drawing.Size(916, 41);
            this.TextBox2CarTypeGallonsDescription.TabIndex = 3;
            this.TextBox2CarTypeGallonsDescription.Text = "You Rented A 2023 Honda Accord Which Holds 14.8 Gallons";
            this.TextBox2CarTypeGallonsDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox2CarTypeGallonsDescription.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBox3EnterDestination
            // 
            this.TextBox3EnterDestination.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox3EnterDestination.Location = new System.Drawing.Point(813, 241);
            this.TextBox3EnterDestination.Multiline = true;
            this.TextBox3EnterDestination.Name = "TextBox3EnterDestination";
            this.TextBox3EnterDestination.Size = new System.Drawing.Size(156, 45);
            this.TextBox3EnterDestination.TabIndex = 4;
            this.TextBox3EnterDestination.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TextBox4EnterMiles
            // 
            this.TextBox4EnterMiles.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TextBox4EnterMiles.Location = new System.Drawing.Point(813, 336);
            this.TextBox4EnterMiles.Multiline = true;
            this.TextBox4EnterMiles.Name = "TextBox4EnterMiles";
            this.TextBox4EnterMiles.Size = new System.Drawing.Size(156, 47);
            this.TextBox4EnterMiles.TabIndex = 5;
            this.TextBox4EnterMiles.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Button1Calculate
            // 
            this.Button1Calculate.Location = new System.Drawing.Point(813, 426);
            this.Button1Calculate.Name = "Button1Calculate";
            this.Button1Calculate.Size = new System.Drawing.Size(188, 78);
            this.Button1Calculate.TabIndex = 6;
            this.Button1Calculate.Text = "CALCULATE";
            this.Button1Calculate.UseVisualStyleBackColor = true;
            this.Button1Calculate.Click += new System.EventHandler(this.Button1Calculate_Click);
            // 
            // Button2Clear
            // 
            this.Button2Clear.Location = new System.Drawing.Point(195, 426);
            this.Button2Clear.Name = "Button2Clear";
            this.Button2Clear.Size = new System.Drawing.Size(200, 78);
            this.Button2Clear.TabIndex = 7;
            this.Button2Clear.Text = "CLEAR";
            this.Button2Clear.UseVisualStyleBackColor = true;
            this.Button2Clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1222, 772);
            this.Controls.Add(this.Button2Clear);
            this.Controls.Add(this.Button1Calculate);
            this.Controls.Add(this.TextBox4EnterMiles);
            this.Controls.Add(this.TextBox3EnterDestination);
            this.Controls.Add(this.TextBox2CarTypeGallonsDescription);
            this.Controls.Add(this.Label2EnterMilesTraveledDestination);
            this.Controls.Add(this.Label1EnterDestinationDescription);
            this.Controls.Add(this.TextBox1StarRentalsHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1StarRentalsHeader;
        private System.Windows.Forms.Label Label1EnterDestinationDescription;
        private System.Windows.Forms.Label Label2EnterMilesTraveledDestination;
        private System.Windows.Forms.TextBox TextBox2CarTypeGallonsDescription;
        private System.Windows.Forms.TextBox TextBox3EnterDestination;
        private System.Windows.Forms.TextBox TextBox4EnterMiles;
        private System.Windows.Forms.Button Button1Calculate;
        private System.Windows.Forms.Button Button2Clear;
    }
}

