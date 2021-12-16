namespace banking2
{
    partial class deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deposit));
            this.label1 = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.TextBox();
            this.amt4 = new System.Windows.Forms.Label();
            this.amt1 = new System.Windows.Forms.Label();
            this.amt2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dLabel = new System.Windows.Forms.Label();
            this.pBal = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deposit:";
            // 
            // amt
            // 
            this.amt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt.Location = new System.Drawing.Point(313, 173);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(239, 30);
            this.amt.TabIndex = 16;
            this.amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amt.Click += new System.EventHandler(this.amt3_Click);
            // 
            // amt4
            // 
            this.amt4.AutoSize = true;
            this.amt4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt4.Location = new System.Drawing.Point(561, 177);
            this.amt4.Name = "amt4";
            this.amt4.Size = new System.Drawing.Size(45, 36);
            this.amt4.TabIndex = 18;
            this.amt4.Text = "Rs";
            this.amt4.Click += new System.EventHandler(this.amt4_Click);
            // 
            // amt1
            // 
            this.amt1.AutoSize = true;
            this.amt1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amt1.Location = new System.Drawing.Point(93, 175);
            this.amt1.Name = "amt1";
            this.amt1.Size = new System.Drawing.Size(218, 36);
            this.amt1.TabIndex = 15;
            this.amt1.Text = "Enter Amount: ";
            // 
            // amt2
            // 
            this.amt2.AutoSize = true;
            this.amt2.Location = new System.Drawing.Point(308, 197);
            this.amt2.Name = "amt2";
            this.amt2.Size = new System.Drawing.Size(247, 13);
            this.amt2.TabIndex = 17;
            this.amt2.Text = "________________________________________";
            this.amt2.Click += new System.EventHandler(this.amt2_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(400, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 88);
            this.button2.TabIndex = 27;
            this.button2.Text = "DEPOSIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // warn
            // 
            this.warn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(104, 309);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(395, 24);
            this.warn.TabIndex = 28;
            this.warn.Text = "Warning:";
            this.warn.Visible = false;
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy/MM/dd";
            this.date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(303, 247);
            this.date.Name = "date";
            this.date.RightToLeftLayout = true;
            this.date.Size = new System.Drawing.Size(197, 33);
            this.date.TabIndex = 58;
            this.date.Value = new System.DateTime(2019, 10, 27, 9, 55, 29, 0);
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(96, 241);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(203, 36);
            this.dLabel.TabIndex = 57;
            this.dLabel.Text = "Today\'s Date:";
            // 
            // pBal
            // 
            this.pBal.AutoSize = true;
            this.pBal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBal.ForeColor = System.Drawing.Color.DarkCyan;
            this.pBal.Location = new System.Drawing.Point(93, 127);
            this.pBal.Name = "pBal";
            this.pBal.Size = new System.Drawing.Size(197, 24);
            this.pBal.TabIndex = 59;
            this.pBal.Text = "<PresentBalance>";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(1001, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 49);
            this.button3.TabIndex = 60;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pBal);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.amt4);
            this.Controls.Add(this.amt1);
            this.Controls.Add(this.amt2);
            this.Controls.Add(this.label1);
            this.Name = "deposit";
            this.Size = new System.Drawing.Size(1062, 447);
            this.Load += new System.EventHandler(this.deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label amt4;
        private System.Windows.Forms.Label amt1;
        private System.Windows.Forms.Label amt2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label pBal;
        private System.Windows.Forms.Button button3;
    }
}
