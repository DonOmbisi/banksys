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
    public partial class loanApproved : UserControl
    {
        public loanApproved()
        {
            InitializeComponent();
        }

        private void loanApproved_Load(object sender, EventArgs e)
        {
            reqnum.Text = applyLoan.reqnum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("applyLoan");
            applyLoan al = new applyLoan();
            al.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(al);
            menu.Instance.PnlContainer.Controls["applyLoan"].BringToFront();
        }
    }
}
