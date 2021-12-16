namespace banking2
{
    partial class enterac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enterac));
            this.label2 = new System.Windows.Forms.Label();
            this.acno = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "____________________________";
            // 
            // acno
            // 
            this.acno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acno.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acno.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.acno.Location = new System.Drawing.Point(248, 184);
            this.acno.MaxLength = 11;
            this.acno.Name = "acno";
            this.acno.Size = new System.Drawing.Size(492, 46);
            this.acno.TabIndex = 2;
            this.acno.Text = "11-digit number";
            this.acno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.acno.Click += new System.EventHandler(this.acno_Click);
            this.acno.TextChanged += new System.EventHandler(this.acno_TextChanged);
            this.acno.MouseEnter += new System.EventHandler(this.acno_MouseEnter);
            this.acno.MouseLeave += new System.EventHandler(this.acno_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(407, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 88);
            this.button2.TabIndex = 62;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // warn
            // 
            this.warn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(230, 274);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(559, 40);
            this.warn.TabIndex = 63;
            this.warn.Text = "Warning:";
            this.warn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(120, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 79);
            this.label1.TabIndex = 64;
            this.label1.Text = "Enter Account Number:";
            // 
            // enterac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.acno);
            this.Controls.Add(this.label2);
            this.Name = "enterac";
            this.Size = new System.Drawing.Size(1062, 447);
            this.Load += new System.EventHandler(this.enterac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox acno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Label label1;
    }
}
