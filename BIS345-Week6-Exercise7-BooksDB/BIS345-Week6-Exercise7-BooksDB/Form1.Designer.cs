namespace BIS345_Week6_Exercise7_BooksDB
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoadCourseBooksButton = new System.Windows.Forms.Button();
            this.ClearGridButton = new System.Windows.Forms.Button();
            this.TestDatabaseConnection = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(245, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Peirce College Course Book Application";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(28, 183);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.Size = new System.Drawing.Size(855, 82);
            this.DataGridView1.TabIndex = 1;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LoadCourseBooksButton
            // 
            this.LoadCourseBooksButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LoadCourseBooksButton.Location = new System.Drawing.Point(392, 418);
            this.LoadCourseBooksButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadCourseBooksButton.Name = "LoadCourseBooksButton";
            this.LoadCourseBooksButton.Size = new System.Drawing.Size(154, 57);
            this.LoadCourseBooksButton.TabIndex = 2;
            this.LoadCourseBooksButton.Text = "Load Course Books";
            this.LoadCourseBooksButton.UseVisualStyleBackColor = false;
            this.LoadCourseBooksButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearGridButton
            // 
            this.ClearGridButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClearGridButton.Location = new System.Drawing.Point(729, 418);
            this.ClearGridButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearGridButton.Name = "ClearGridButton";
            this.ClearGridButton.Size = new System.Drawing.Size(154, 57);
            this.ClearGridButton.TabIndex = 3;
            this.ClearGridButton.Text = "Clear Grid";
            this.ClearGridButton.UseVisualStyleBackColor = false;
            this.ClearGridButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestDatabaseConnection
            // 
            this.TestDatabaseConnection.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TestDatabaseConnection.Location = new System.Drawing.Point(28, 418);
            this.TestDatabaseConnection.Margin = new System.Windows.Forms.Padding(2);
            this.TestDatabaseConnection.Name = "TestDatabaseConnection";
            this.TestDatabaseConnection.Size = new System.Drawing.Size(154, 57);
            this.TestDatabaseConnection.TabIndex = 4;
            this.TestDatabaseConnection.Text = "Test Database Connection";
            this.TestDatabaseConnection.UseVisualStyleBackColor = false;
            this.TestDatabaseConnection.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(431, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Session 2 (2023)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 500);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TestDatabaseConnection);
            this.Controls.Add(this.ClearGridButton);
            this.Controls.Add(this.LoadCourseBooksButton);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Peirce College Course Book Application";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button LoadCourseBooksButton;
        private System.Windows.Forms.Button ClearGridButton;
        private System.Windows.Forms.Button TestDatabaseConnection;
        private System.Windows.Forms.TextBox textBox2;
    }
}

