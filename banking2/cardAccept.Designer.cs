namespace banking2
{
    partial class cardAccept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardAccept));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.provider = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 33);
            this.label5.TabIndex = 78;
            this.label5.Text = "Date of  Recieving: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 33);
            this.label4.TabIndex = 77;
            this.label4.Text = "Card Provider: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 33);
            this.label3.TabIndex = 76;
            this.label3.Text = "Type Of Card: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 75;
            this.label1.Text = "Enter Card No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 33);
            this.label2.TabIndex = 79;
            this.label2.Text = "Enter Account No:";
            // 
            // acno
            // 
            this.acno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acno.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acno.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.acno.Location = new System.Drawing.Point(289, 82);
            this.acno.MaxLength = 11;
            this.acno.Name = "acno";
            this.acno.Size = new System.Drawing.Size(492, 30);
            this.acno.TabIndex = 81;
            this.acno.Text = "11-digit number";
            this.acno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.acno.Click += new System.EventHandler(this.acno_Click);
            this.acno.TextChanged += new System.EventHandler(this.acno_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(522, 42);
            this.label6.TabIndex = 80;
            this.label6.Text = "____________________________";
            // 
            // cardNo
            // 
            this.cardNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cardNo.Location = new System.Drawing.Point(240, 29);
            this.cardNo.MaxLength = 16;
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(492, 30);
            this.cardNo.TabIndex = 83;
            this.cardNo.Text = "16-digit number";
            this.cardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cardNo.Click += new System.EventHandler(this.cardNo_Click);
            this.cardNo.TextChanged += new System.EventHandler(this.cardNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(522, 42);
            this.label7.TabIndex = 82;
            this.label7.Text = "____________________________";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "CREDIT CARD",
            "DEBIT CARD"});
            this.type.Location = new System.Drawing.Point(235, 131);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(242, 38);
            this.type.TabIndex = 84;
            // 
            // provider
            // 
            this.provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provider.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provider.FormattingEnabled = true;
            this.provider.Items.AddRange(new object[] {
            "VISA",
            "Master Card",
            "RuPay"});
            this.provider.Location = new System.Drawing.Point(238, 183);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(242, 38);
            this.provider.TabIndex = 85;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(294, 236);
            this.date.Name = "date";
            this.date.RightToLeftLayout = true;
            this.date.Size = new System.Drawing.Size(252, 37);
            this.date.TabIndex = 86;
            this.date.Value = new System.DateTime(2019, 10, 27, 9, 55, 29, 0);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(397, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 88);
            this.button2.TabIndex = 87;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // warn
            // 
            this.warn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(23, 332);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(559, 30);
            this.warn.TabIndex = 88;
            this.warn.Text = "Warning:";
            this.warn.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 33);
            this.label8.TabIndex = 89;
            this.label8.Text = "Expiry Date:";
            // 
            // expDate
            // 
            this.expDate.CustomFormat = "yyyy/MM/dd";
            this.expDate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expDate.Location = new System.Drawing.Point(214, 291);
            this.expDate.Name = "expDate";
            this.expDate.RightToLeftLayout = true;
            this.expDate.Size = new System.Drawing.Size(252, 37);
            this.expDate.TabIndex = 90;
            this.expDate.Value = new System.DateTime(2019, 10, 27, 9, 55, 29, 0);
            // 
            // cardAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.expDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.type);
            this.Controls.Add(this.cardNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.acno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "cardAccept";
            this.Size = new System.Drawing.Size(1062, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox acno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cardNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox provider;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker expDate;
    }
}
