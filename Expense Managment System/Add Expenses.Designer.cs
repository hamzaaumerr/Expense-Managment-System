namespace WinFormsApp1
{
    partial class Add_Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Expenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.exNameTb = new System.Windows.Forms.TextBox();
            this.exAmountTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exCategoryCb = new System.Windows.Forms.ComboBox();
            this.exDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.exDescriptionTb = new System.Windows.Forms.TextBox();
            this.addExBtn = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add Expenses";
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
            // exNameTb
            // 
            this.exNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exNameTb.Location = new System.Drawing.Point(402, 88);
            this.exNameTb.Name = "exNameTb";
            this.exNameTb.Size = new System.Drawing.Size(282, 29);
            this.exNameTb.TabIndex = 0;
            // 
            // exAmountTb
            // 
            this.exAmountTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exAmountTb.Location = new System.Drawing.Point(402, 166);
            this.exAmountTb.Name = "exAmountTb";
            this.exAmountTb.Size = new System.Drawing.Size(282, 29);
            this.exAmountTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(158, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Expense Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(158, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expense Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(158, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Expense Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(158, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Expense Date";
            // 
            // exCategoryCb
            // 
            this.exCategoryCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exCategoryCb.FormattingEnabled = true;
            this.exCategoryCb.Items.AddRange(new object[] {
            "Food",
            "Shopping",
            "Travel",
            "Vehicle",
            "Medical",
            "Household",
            "Other"});
            this.exCategoryCb.Location = new System.Drawing.Point(402, 236);
            this.exCategoryCb.Name = "exCategoryCb";
            this.exCategoryCb.Size = new System.Drawing.Size(282, 29);
            this.exCategoryCb.TabIndex = 2;
            // 
            // exDateDtp
            // 
            this.exDateDtp.CustomFormat = "dd/MM/yyyy";
            this.exDateDtp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.exDateDtp.Location = new System.Drawing.Point(402, 304);
            this.exDateDtp.Name = "exDateDtp";
            this.exDateDtp.Size = new System.Drawing.Size(282, 29);
            this.exDateDtp.TabIndex = 3;
            this.exDateDtp.Value = new System.DateTime(2022, 6, 27, 12, 31, 44, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(158, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expense Description";
            // 
            // exDescriptionTb
            // 
            this.exDescriptionTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exDescriptionTb.Location = new System.Drawing.Point(402, 371);
            this.exDescriptionTb.Multiline = true;
            this.exDescriptionTb.Name = "exDescriptionTb";
            this.exDescriptionTb.Size = new System.Drawing.Size(282, 114);
            this.exDescriptionTb.TabIndex = 4;
            // 
            // addExBtn
            // 
            this.addExBtn.BackColor = System.Drawing.Color.Green;
            this.addExBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExBtn.ForeColor = System.Drawing.Color.White;
            this.addExBtn.Location = new System.Drawing.Point(318, 508);
            this.addExBtn.Name = "addExBtn";
            this.addExBtn.Size = new System.Drawing.Size(103, 31);
            this.addExBtn.TabIndex = 5;
            this.addExBtn.Text = "Add Expense";
            this.addExBtn.UseVisualStyleBackColor = false;
            this.addExBtn.Click += new System.EventHandler(this.addExBtn_Click);
            // 
            // Add_Expenses
            // 
            this.AcceptButton = this.addExBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 568);
            this.Controls.Add(this.addExBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exDescriptionTb);
            this.Controls.Add(this.exDateDtp);
            this.Controls.Add(this.exCategoryCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exAmountTb);
            this.Controls.Add(this.exNameTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Expenses";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private TextBox exNameTb;
        private TextBox exAmountTb;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox exCategoryCb;
        private DateTimePicker exDateDtp;
        private Label label6;
        private TextBox exDescriptionTb;
        private Button addExBtn;
    }
}