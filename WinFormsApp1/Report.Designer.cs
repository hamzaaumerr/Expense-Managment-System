namespace WinFormsApp1
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.maxLbl = new System.Windows.Forms.Label();
            this.hiExLbl = new System.Windows.Forms.Label();
            this.totLbl = new System.Windows.Forms.Label();
            this.avgLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.loExLbl = new System.Windows.Forms.Label();
            this.exCatCb = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 62);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Report";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(149, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(721, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxLbl.Location = new System.Drawing.Point(536, 180);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(48, 25);
            this.maxLbl.TabIndex = 21;
            this.maxLbl.Text = "Max";
            // 
            // hiExLbl
            // 
            this.hiExLbl.AutoSize = true;
            this.hiExLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hiExLbl.Location = new System.Drawing.Point(538, 437);
            this.hiExLbl.Name = "hiExLbl";
            this.hiExLbl.Size = new System.Drawing.Size(49, 25);
            this.hiExLbl.TabIndex = 22;
            this.hiExLbl.Text = "HiEx";
            this.hiExLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // totLbl
            // 
            this.totLbl.AutoSize = true;
            this.totLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totLbl.Location = new System.Drawing.Point(536, 370);
            this.totLbl.Name = "totLbl";
            this.totLbl.Size = new System.Drawing.Size(37, 25);
            this.totLbl.TabIndex = 23;
            this.totLbl.Text = "Tot";
            // 
            // avgLbl
            // 
            this.avgLbl.AutoSize = true;
            this.avgLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avgLbl.Location = new System.Drawing.Point(536, 302);
            this.avgLbl.Name = "avgLbl";
            this.avgLbl.Size = new System.Drawing.Size(44, 25);
            this.avgLbl.TabIndex = 24;
            this.avgLbl.Text = "Avg";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minLbl.Location = new System.Drawing.Point(536, 240);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(45, 25);
            this.minLbl.TabIndex = 25;
            this.minLbl.Text = "Min";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLbl.Location = new System.Drawing.Point(215, 110);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(79, 25);
            this.amountLbl.TabIndex = 26;
            this.amountLbl.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(158, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Maximum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(158, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Minimum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(158, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Average";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(158, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(158, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "Highest Expense Category";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(158, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Lowest Expense Category";
            // 
            // loExLbl
            // 
            this.loExLbl.AutoSize = true;
            this.loExLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loExLbl.Location = new System.Drawing.Point(536, 507);
            this.loExLbl.Name = "loExLbl";
            this.loExLbl.Size = new System.Drawing.Size(51, 25);
            this.loExLbl.TabIndex = 33;
            this.loExLbl.Text = "LoEx";
            // 
            // exCatCb
            // 
            this.exCatCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exCatCb.FormattingEnabled = true;
            this.exCatCb.Items.AddRange(new object[] {
            "Food",
            "Shopping",
            "Travel",
            "Vehicle",
            "Medical",
            "Household",
            "Other"});
            this.exCatCb.Location = new System.Drawing.Point(12, 110);
            this.exCatCb.Name = "exCatCb";
            this.exCatCb.Size = new System.Drawing.Size(170, 29);
            this.exCatCb.TabIndex = 35;
            this.exCatCb.SelectionChangeCommitted += new System.EventHandler(this.exCatCb_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(12, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 25);
            this.label15.TabIndex = 34;
            this.label15.Text = "Expense Category";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countLbl.Location = new System.Drawing.Point(666, 110);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(63, 25);
            this.countLbl.TabIndex = 36;
            this.countLbl.Text = "Count";
            this.countLbl.Click += new System.EventHandler(this.countLbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(472, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Number Of Expenses";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.exCatCb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.loExLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.avgLbl);
            this.Controls.Add(this.totLbl);
            this.Controls.Add(this.hiExLbl);
            this.Controls.Add(this.maxLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label maxLbl;
        private Label hiExLbl;
        private Label totLbl;
        private Label avgLbl;
        private Label minLbl;
        private Label amountLbl;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label loExLbl;
        private ComboBox exCatCb;
        private Label label15;
        private Label countLbl;
        private Label label3;
    }
}