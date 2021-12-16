using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking2
{
    public partial class loans : UserControl
    {
        public loans()
        {
            InitializeComponent();
        }

        private void label2_Enter(object sender, EventArgs e)
        {
           
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            
            label2.ForeColor = Color.Black;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Focus();
            label2.ForeColor = Color.DarkCyan;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("applyLoan");
            applyLoan ap = new applyLoan();
            ap.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(ap);
            menu.Instance.PnlContainer.Controls["applyLoan"].BringToFront();

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkCyan;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("enterLoanNo");
            enterLoanNo ap = new enterLoanNo();
            ap.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(ap);
            menu.Instance.PnlContainer.Controls["enterLoanNo"].BringToFront();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("enterLoanNo1");
            enterLoanNo1 la = new enterLoanNo1();
            la.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(la);
            menu.Instance.PnlContainer.Controls["enterLoanNo1"].BringToFront();
        }

        private void label3_MouseEnter_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkCyan;

        }

        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("enterLoanNo2");
            enterLoanNo2 la = new enterLoanNo2();
            la.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(la);
            menu.Instance.PnlContainer.Controls["enterLoanNo2"].BringToFront();
        }
    }
}
