namespace banking2
{
    partial class adminLoanApproval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLoanApproval));
            this.label1 = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.acInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.warn = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amt1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.Label();
            this.proof = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.req_no = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 79);
            this.label1.TabIndex = 12;
            this.label1.Text = "Loan Requests:";
            // 
            // red
            // 
            this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
            this.red.Location = new System.Drawing.Point(740, 81);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(34, 28);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red.TabIndex = 106;
            this.red.TabStop = false;
            this.red.Visible = false;
            // 
            // green
            // 
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.Location = new System.Drawing.Point(740, 81);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(34, 28);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.green.TabIndex = 105;
            this.green.TabStop = false;
            this.green.Visible = false;
            // 
            // acInfo
            // 
            this.acInfo.AutoSize = true;
            this.acInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acInfo.ForeColor = System.Drawing.Color.Green;
            this.acInfo.Location = new System.Drawing.Point(499, 168);
            this.acInfo.Name = "acInfo";
            this.acInfo.Size = new System.Drawing.Size(85, 16);
            this.acInfo.TabIndex = 104;
            this.acInfo.Text = "<bank info>";
            this.acInfo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 19);
            this.label8.TabIndex = 100;
            this.label8.Text = "Collateral Provided: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(498, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 19);
            this.label6.TabIndex = 97;
            this.label6.Text = " Time Period(Months).: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(82, 351);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(264, 19);
            this.warn.TabIndex = 96;
            this.warn.Text = "<display warnings and cautions>";
            this.warn.Visible = false;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(82, 246);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(120, 19);
            this.dLabel.TabIndex = 94;
            this.dLabel.Text = "Date Applied: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = " Account No.: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // amt1
            // 
            this.amt1.AutoSize = true;
            this.amt1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt1.Location = new System.Drawing.Point(500, 111);
            this.amt1.Name = "amt1";
            this.amt1.Size = new System.Drawing.Size(83, 19);
            this.amt1.TabIndex = 87;
            this.amt1.Text = " Amount: ";
            this.amt1.Click += new System.EventHandler(this.amt1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "Type Of Loan: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 19);
            this.label2.TabIndex = 107;
            this.label2.Text = "Are the collateral documents verified?\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 108;
            this.label5.Text = "Status: ";
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "PROCESSING",
            "REJECTED",
            "APPROVED"});
            this.status.Location = new System.Drawing.Point(137, 278);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(155, 28);
            this.status.TabIndex = 109;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(431, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 76);
            this.button2.TabIndex = 110;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(196, 124);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(120, 21);
            this.type.TabIndex = 111;
            this.type.Text = "Type Of Loan: ";
            // 
            // proof
            // 
            this.proof.AutoSize = true;
            this.proof.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proof.Location = new System.Drawing.Point(234, 156);
            this.proof.Name = "proof";
            this.proof.Size = new System.Drawing.Size(120, 21);
            this.proof.TabIndex = 112;
            this.proof.Text = "Type Of Loan: ";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(192, 246);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(120, 21);
            this.date.TabIndex = 113;
            this.date.Text = "Type Of Loan: ";
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(615, 84);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(120, 21);
            this.account.TabIndex = 114;
            this.account.Text = "Type Of Loan: ";
            // 
            // amt
            // 
            this.amt.AutoSize = true;
            this.amt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.Location = new System.Drawing.Point(581, 111);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(120, 21);
            this.amt.TabIndex = 115;
            this.amt.Text = "Type Of Loan: ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(676, 137);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 21);
            this.time.TabIndex = 116;
            this.time.Text = "Type Of Loan: ";
            // 
            // req_no
            // 
            this.req_no.AutoSize = true;
            this.req_no.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.req_no.ForeColor = System.Drawing.Color.Teal;
            this.req_no.Location = new System.Drawing.Point(175, 95);
            this.req_no.Name = "req_no";
            this.req_no.Size = new System.Drawing.Size(139, 23);
            this.req_no.TabIndex = 120;
            this.req_no.Text = "Type Of Loan: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 119;
            this.label9.Text = "Request No:";
            // 
            // date1
            // 
            this.date1.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.CustomFormat = "yyyy/MM/dd";
            this.date1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(195, 314);
            this.date1.Name = "date1";
            this.date1.RightToLeftLayout = true;
            this.date1.Size = new System.Drawing.Size(126, 26);
            this.date1.TabIndex = 122;
            this.date1.Value = new System.DateTime(2019, 10, 27, 9, 55, 29, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 121;
            this.label7.Text = "Today\'s Date: ";
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.Location = new System.Drawing.Point(93, 216);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(48, 20);
            this.yes.TabIndex = 123;
            this.yes.TabStop = true;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(147, 216);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(44, 20);
            this.no.TabIndex = 124;
            this.no.TabStop = true;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 125;
            this.label10.Text = "Remarks: ";
            // 
            // rem
            // 
            this.rem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rem.Location = new System.Drawing.Point(584, 305);
            this.rem.Multiline = true;
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(331, 61);
            this.rem.TabIndex = 126;
            // 
            // adminLoanApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.req_no);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.time);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.account);
            this.Controls.Add(this.date);
            this.Controls.Add(this.proof);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.red);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.green);
            this.Controls.Add(this.acInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Name = "adminLoanApproval";
            this.Size = new System.Drawing.Size(1062, 447);
            this.Load += new System.EventHandler(this.adminLoanApproval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.Label acInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label amt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label proof;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label amt;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label req_no;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rem;
    }
}
