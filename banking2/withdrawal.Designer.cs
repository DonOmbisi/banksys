namespace banking2
{
    partial class withdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withdrawal));
            this.label1 = new System.Windows.Forms.Label();
            this.medium = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cheq1 = new System.Windows.Forms.Label();
            this.cheq2 = new System.Windows.Forms.TextBox();
            this.cheq3 = new System.Windows.Forms.Label();
            this.amt1 = new System.Windows.Forms.Label();
            this.amt3 = new System.Windows.Forms.TextBox();
            this.amt2 = new System.Windows.Forms.Label();
            this.amt4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pBal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Withdrawal:\r\n";
            // 
            // medium
            // 
            this.medium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medium.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium.ForeColor = System.Drawing.Color.Black;
            this.medium.FormattingEnabled = true;
            this.medium.Items.AddRange(new object[] {
            "Through Cheque",
            "Form Based"});
            this.medium.Location = new System.Drawing.Point(358, 140);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(272, 38);
            this.medium.TabIndex = 6;
            this.medium.SelectedIndexChanged += new System.EventHandler(this.medium_SelectedIndexChanged);
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "WIthdrawal Medium:";
            // 
            // cheq1
            // 
            this.cheq1.AutoSize = true;
            this.cheq1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheq1.Location = new System.Drawing.Point(104, 193);
            this.cheq1.Name = "cheq1";
            this.cheq1.Size = new System.Drawing.Size(220, 28);
            this.cheq1.TabIndex = 8;
            this.cheq1.Text = "Cheque Number: ";
            this.cheq1.Visible = false;
            // 
            // cheq2
            // 
            this.cheq2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cheq2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheq2.Location = new System.Drawing.Point(324, 189);
            this.cheq2.MaxLength = 7;
            this.cheq2.Name = "cheq2";
            this.cheq2.Size = new System.Drawing.Size(230, 24);
            this.cheq2.TabIndex = 9;
            this.cheq2.Text = "7-digit";
            this.cheq2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cheq2.Visible = false;
            this.cheq2.Click += new System.EventHandler(this.cheq2_Click);
            // 
            // cheq3
            // 
            this.cheq3.AutoSize = true;
            this.cheq3.Location = new System.Drawing.Point(313, 205);
            this.cheq3.Name = "cheq3";
            this.cheq3.Size = new System.Drawing.Size(247, 13);
            this.cheq3.TabIndex = 10;
            this.cheq3.Text = "________________________________________";
            this.cheq3.Visible = false;
            // 
            // amt1
            // 
            this.amt1.AutoSize = true;
            this.amt1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt1.Location = new System.Drawing.Point(108, 240);
            this.amt1.Name = "amt1";
            this.amt1.Size = new System.Drawing.Size(180, 28);
            this.amt1.TabIndex = 11;
            this.amt1.Text = "Enter Amount: ";
            this.amt1.Visible = false;
            // 
            // amt3
            // 
            this.amt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amt3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt3.Location = new System.Drawing.Point(300, 239);
            this.amt3.Name = "amt3";
            this.amt3.Size = new System.Drawing.Size(239, 24);
            this.amt3.TabIndex = 12;
            this.amt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amt3.Visible = false;
            // 
            // amt2
            // 
            this.amt2.AutoSize = true;
            this.amt2.Location = new System.Drawing.Point(296, 257);
            this.amt2.Name = "amt2";
            this.amt2.Size = new System.Drawing.Size(247, 13);
            this.amt2.TabIndex = 13;
            this.amt2.Text = "________________________________________";
            this.amt2.Visible = false;
            // 
            // amt4
            // 
            this.amt4.AutoSize = true;
            this.amt4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt4.Location = new System.Drawing.Point(545, 248);
            this.amt4.Name = "amt4";
            this.amt4.Size = new System.Drawing.Size(29, 23);
            this.amt4.TabIndex = 14;
            this.amt4.Text = "Rs";
            this.amt4.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(383, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 88);
            this.button2.TabIndex = 26;
            this.button2.Text = "WITHDRAW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // warn
            // 
            this.warn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(106, 340);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(395, 24);
            this.warn.TabIndex = 27;
            this.warn.Text = "Warning:";
            this.warn.Visible = false;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(349, 282);
            this.date.Name = "date";
            this.date.RightToLeftLayout = true;
            this.date.Size = new System.Drawing.Size(152, 33);
            this.date.TabIndex = 56;
            this.date.Value = new System.DateTime(2019, 10, 27, 9, 55, 29, 0);
            this.date.Visible = false;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(109, 285);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(237, 28);
            this.dLabel.TabIndex = 55;
            this.dLabel.Text = "Date of withdrawal:";
            this.dLabel.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(998, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 49);
            this.button3.TabIndex = 57;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pBal
            // 
            this.pBal.AutoSize = true;
            this.pBal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBal.ForeColor = System.Drawing.Color.DarkCyan;
            this.pBal.Location = new System.Drawing.Point(103, 107);
            this.pBal.Name = "pBal";
            this.pBal.Size = new System.Drawing.Size(197, 24);
            this.pBal.TabIndex = 58;
            this.pBal.Text = "<PresentBalance>";
            // 
            // withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pBal);
            this.Controls.Add(this.amt3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.amt4);
            this.Controls.Add(this.amt1);
            this.Controls.Add(this.amt2);
            this.Controls.Add(this.cheq1);
            this.Controls.Add(this.cheq2);
            this.Controls.Add(this.cheq3);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "withdrawal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1062, 447);
            this.Load += new System.EventHandler(this.withdrawal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medium;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cheq1;
        private System.Windows.Forms.TextBox cheq2;
        private System.Windows.Forms.Label cheq3;
        private System.Windows.Forms.Label amt1;
        private System.Windows.Forms.TextBox amt3;
        private System.Windows.Forms.Label amt2;
        private System.Windows.Forms.Label amt4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label pBal;
    }
}
