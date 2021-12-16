namespace banking2
{
    partial class applyLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(applyLoan));
            this.label1 = new System.Windows.Forms.Label();
            this.loanType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.TextBox();
            this.amt4 = new System.Windows.Forms.Label();
            this.amt1 = new System.Windows.Forms.Label();
            this.amt2 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dLabel = new System.Windows.Forms.Label();
            this.warn = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.loaninfo = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.col = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.oth = new System.Windows.Forms.Label();
            this.oth1 = new System.Windows.Forms.TextBox();
            this.acInfo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Apply For A Loan: \r\n";
            // 
            // loanType
            // 
            this.loanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loanType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanType.ForeColor = System.Drawing.Color.Black;
            this.loanType.FormattingEnabled = true;
            this.loanType.Items.AddRange(new object[] {
            "Car Loan",
            "Home Loan",
            "Agriculture Loan",
            "Student Loan",
            "Jewellery Loan",
            "Bussiness Loan"});
            this.loanType.Location = new System.Drawing.Point(215, 91);
            this.loanType.Name = "loanType";
            this.loanType.Size = new System.Drawing.Size(206, 28);
            this.loanType.TabIndex = 8;
            this.loanType.SelectedIndexChanged += new System.EventHandler(this.medium_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type Of Loan: ";
            // 
            // amt
            // 
            this.amt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.Location = new System.Drawing.Point(216, 126);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(239, 20);
            this.amt.TabIndex = 62;
            this.amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amt4
            // 
            this.amt4.AutoSize = true;
            this.amt4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt4.Location = new System.Drawing.Point(463, 126);
            this.amt4.Name = "amt4";
            this.amt4.Size = new System.Drawing.Size(23, 18);
            this.amt4.TabIndex = 64;
            this.amt4.Text = "Rs";
            // 
            // amt1
            // 
            this.amt1.AutoSize = true;
            this.amt1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt1.Location = new System.Drawing.Point(95, 131);
            this.amt1.Name = "amt1";
            this.amt1.Size = new System.Drawing.Size(120, 19);
            this.amt1.TabIndex = 61;
            this.amt1.Text = "Enter Amount: ";
            // 
            // amt2
            // 
            this.amt2.AutoSize = true;
            this.amt2.Location = new System.Drawing.Point(210, 136);
            this.amt2.Name = "amt2";
            this.amt2.Size = new System.Drawing.Size(247, 13);
            this.amt2.TabIndex = 63;
            this.amt2.Text = "________________________________________";
            // 
            // acc
            // 
            this.acc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.Location = new System.Drawing.Point(278, 195);
            this.acc.MaxLength = 11;
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(239, 20);
            this.acc.TabIndex = 66;
            this.acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.acc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Enter Account No.: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "________________________________________";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(223, 303);
            this.date.Name = "date";
            this.date.RightToLeftLayout = true;
            this.date.Size = new System.Drawing.Size(126, 26);
            this.date.TabIndex = 69;
            this.date.Value = new System.DateTime(2019, 10, 27, 9, 55, 29, 0);
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(98, 306);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(115, 19);
            this.dLabel.TabIndex = 68;
            this.dLabel.Text = "Today\'s Date: ";
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(104, 347);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(264, 19);
            this.warn.TabIndex = 70;
            this.warn.Text = "<display warnings and cautions>";
            this.warn.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(438, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 76);
            this.button2.TabIndex = 71;
            this.button2.Text = "APPLY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loaninfo
            // 
            this.loaninfo.AutoSize = true;
            this.loaninfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaninfo.ForeColor = System.Drawing.Color.DarkCyan;
            this.loaninfo.Location = new System.Drawing.Point(615, 91);
            this.loaninfo.Name = "loaninfo";
            this.loaninfo.Size = new System.Drawing.Size(306, 23);
            this.loaninfo.TabIndex = 72;
            this.loaninfo.Text = "<emi  calculator and other stuff>";
            // 
            // time
            // 
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(309, 162);
            this.time.MaxLength = 3;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(239, 20);
            this.time.TabIndex = 74;
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Enter Time Period(Months).: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "________________________________________";
            // 
            // col
            // 
            this.col.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.col.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col.ForeColor = System.Drawing.Color.Black;
            this.col.FormattingEnabled = true;
            this.col.Items.AddRange(new object[] {
            "Land Documents",
            "Salaried Account",
            "Others"});
            this.col.Location = new System.Drawing.Point(263, 226);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(206, 29);
            this.col.TabIndex = 77;
            this.col.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Collateral Provided: ";
            // 
            // oth
            // 
            this.oth.AutoSize = true;
            this.oth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oth.Location = new System.Drawing.Point(95, 266);
            this.oth.Name = "oth";
            this.oth.Size = new System.Drawing.Size(127, 19);
            this.oth.TabIndex = 78;
            this.oth.Text = "Please Specify :";
            this.oth.Visible = false;
            // 
            // oth1
            // 
            this.oth1.BackColor = System.Drawing.Color.LightGray;
            this.oth1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oth1.Location = new System.Drawing.Point(228, 267);
            this.oth1.Multiline = true;
            this.oth1.Name = "oth1";
            this.oth1.Size = new System.Drawing.Size(296, 27);
            this.oth1.TabIndex = 79;
            this.oth1.Visible = false;
            this.oth1.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // acInfo
            // 
            this.acInfo.AutoSize = true;
            this.acInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acInfo.ForeColor = System.Drawing.Color.Green;
            this.acInfo.Location = new System.Drawing.Point(617, 199);
            this.acInfo.Name = "acInfo";
            this.acInfo.Size = new System.Drawing.Size(306, 23);
            this.acInfo.TabIndex = 81;
            this.acInfo.Text = "<emi  calculator and other stuff>";
            this.acInfo.Visible = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(1009, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 49);
            this.button3.TabIndex = 82;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // green
            // 
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.Location = new System.Drawing.Point(521, 196);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(34, 28);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.green.TabIndex = 83;
            this.green.TabStop = false;
            this.green.Visible = false;
            // 
            // red
            // 
            this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
            this.red.Location = new System.Drawing.Point(522, 196);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(34, 28);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red.TabIndex = 84;
            this.red.TabStop = false;
            this.red.Visible = false;
            // 
            // applyLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.red);
            this.Controls.Add(this.green);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.acInfo);
            this.Controls.Add(this.oth1);
            this.Controls.Add(this.oth);
            this.Controls.Add(this.col);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loaninfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amt4);
            this.Controls.Add(this.amt1);
            this.Controls.Add(this.amt2);
            this.Controls.Add(this.loanType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "applyLoan";
            this.Size = new System.Drawing.Size(1062, 447);
            this.Load += new System.EventHandler(this.applyLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox loanType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label amt4;
        private System.Windows.Forms.Label amt1;
        private System.Windows.Forms.Label amt2;
        private System.Windows.Forms.TextBox acc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label loaninfo;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox col;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label oth;
        private System.Windows.Forms.TextBox oth1;
        private System.Windows.Forms.Label acInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox red;
    }
}
