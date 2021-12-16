namespace banking2
{
    partial class enterLoanNo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(enterLoanNo1));
            this.warn = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // warn
            // 
            this.warn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warn.ForeColor = System.Drawing.Color.Red;
            this.warn.Location = new System.Drawing.Point(244, 253);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(559, 40);
            this.warn.TabIndex = 73;
            this.warn.Text = "Warning:";
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
            this.button2.Location = new System.Drawing.Point(427, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 88);
            this.button2.TabIndex = 72;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lno
            // 
            this.lno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lno.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lno.Location = new System.Drawing.Point(262, 153);
            this.lno.MaxLength = 11;
            this.lno.Name = "lno";
            this.lno.Size = new System.Drawing.Size(492, 46);
            this.lno.TabIndex = 71;
            this.lno.Text = "Please Fill";
            this.lno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lno.Click += new System.EventHandler(this.lno_Click);
            this.lno.TextChanged += new System.EventHandler(this.lno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 46);
            this.label2.TabIndex = 70;
            this.label2.Text = "____________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(77, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 79);
            this.label3.TabIndex = 74;
            this.label3.Text = "Enter Loan Request Number";
            // 
            // enterLoanNo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lno);
            this.Controls.Add(this.label2);
            this.Name = "enterLoanNo1";
            this.Size = new System.Drawing.Size(1062, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label warn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
