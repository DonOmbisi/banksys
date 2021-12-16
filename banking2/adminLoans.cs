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
    public partial class adminLoans : UserControl
    {
        public adminLoans()
        {
            InitializeComponent();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkCyan;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("loanReq");
            loanReq lr = new loanReq();
            lr.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(lr);
            menu.Instance.PnlContainer.Controls["loanReq"].BringToFront();
        }

        private void adminLoans_Load(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkCyan;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("rejected");
            rejected r = new rejected();
            r.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(r);
            menu.Instance.PnlContainer.Controls["rejected"].BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("todayLoan");
            todayLoan r = new todayLoan();
            r.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(r);
            menu.Instance.PnlContainer.Controls["todayLoan"].BringToFront();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkCyan;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label5_MouseEnter_1(object sender, EventArgs e)
        {
            

        }

        private void label5_MouseLeave_1(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("enterLoanNo");
            enterLoanNo r = new enterLoanNo();
            r.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(r);
            menu.Instance.PnlContainer.Controls["enterLoanNo"].BringToFront();
        }

        private void label5_MouseEnter_2(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkCyan;
        }

        private void label5_MouseLeave_2(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("enterLoanNo");
            enterLoanNo r = new enterLoanNo();
            r.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(r);
            menu.Instance.PnlContainer.Controls["enterLoanNo"].BringToFront();
        }
    }
}
