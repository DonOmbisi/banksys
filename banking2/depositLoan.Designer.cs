namespace banking2
{
    partial class depositLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depositLoan));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amt3 = new System.Windows.Forms.TextBox();
            this.amt4 = new System.Windows.Forms.Label();
            this.amt1 = new System.Windows.Forms.Label();
            this.amt2 = new System.Windows.Forms.Label();
            this.pBal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(435, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 88);
            this.button2.TabIndex = 86;
            this.button2.Text = "APPROVE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(73, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "<rate and other details about the loan>";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(245, 313);
            this.date.Name = "date";
            this.date.RightToLeftLayout = true;
            this.date.Size = new System.Drawing.Size(152, 33);
            this.date.TabIndex = 84;
            this.date.Value = new System.DateTime(2019, 10, 27, 9, 55, 29, 0);
            this.date.Visible = false;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(74, 313);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(175, 28);
            this.dLabel.TabIndex = 83;
            this.dLabel.Text = "Today\'s Date: ";
            this.dLabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(298, 85);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 24);
            this.textBox1.TabIndex = 81;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 28);
            this.label4.TabIndex = 80;
            this.label4.Text = "Enter Account No.: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "________________________________________";
            // 
            // amt3
            // 
            this.amt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amt3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt3.Location = new System.Drawing.Point(261, 181);
            this.amt3.Name = "amt3";
            this.amt3.Size = new System.Drawing.Size(239, 24);
            this.amt3.TabIndex = 77;
            this.amt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amt4
            // 
            this.amt4.AutoSize = true;
            this.amt4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt4.Location = new System.Drawing.Point(506, 190);
            this.amt4.Name = "amt4";
            this.amt4.Size = new System.Drawing.Size(29, 23);
            this.amt4.TabIndex = 79;
            this.amt4.Text = "Rs";
            // 
            // amt1
            // 
            this.amt1.AutoSize = true;
            this.amt1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt1.Location = new System.Drawing.Point(69, 182);
            this.amt1.Name = "amt1";
            this.amt1.Size = new System.Drawing.Size(180, 28);
            this.amt1.TabIndex = 76;
            this.amt1.Text = "Enter Amount: ";
            // 
            // amt2
            // 
            this.amt2.AutoSize = true;
            this.amt2.Location = new System.Drawing.Point(257, 199);
            this.amt2.Name = "amt2";
            this.amt2.Size = new System.Drawing.Size(247, 13);
            this.amt2.TabIndex = 78;
            this.amt2.Text = "________________________________________";
            // 
            // pBal
            // 
            this.pBal.AutoSize = true;
            this.pBal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBal.ForeColor = System.Drawing.Color.DarkCyan;
            this.pBal.Location = new System.Drawing.Point(70, 137);
            this.pBal.Name = "pBal";
            this.pBal.Size = new System.Drawing.Size(422, 24);
            this.pBal.TabIndex = 75;
            this.pBal.Text = "<rate and other details about the loan>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 58);
            this.label1.TabIndex = 72;
            this.label1.Text = "Installment Deposit: ";
            // 
            // depositLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amt3);
            this.Controls.Add(this.amt4);
            this.Controls.Add(this.amt1);
            this.Controls.Add(this.amt2);
            this.Controls.Add(this.pBal);
            this.Controls.Add(this.label1);
            this.Name = "depositLoan";
            this.Size = new System.Drawing.Size(1062, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amt3;
        private System.Windows.Forms.Label amt4;
        private System.Windows.Forms.Label amt1;
        private System.Windows.Forms.Label amt2;
        private System.Windows.Forms.Label pBal;
        private System.Windows.Forms.Label label1;
    }
}
