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
    public partial class bankInfo : UserControl
    {
        public bankInfo()
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

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkCyan;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkCyan;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkCyan;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("customers");
            customers c = new customers();
            c.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(c);
            menu.Instance.PnlContainer.Controls["customers"].BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("adminEmployee");
            adminEmployee c = new adminEmployee();
            c.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(c);
            menu.Instance.PnlContainer.Controls["adminEmployee"].BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("totalLoans");
            totalLoans c = new totalLoans();
            c.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(c);
            menu.Instance.PnlContainer.Controls["totalLoans"].BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("adminCardReq");
            adminCardReq c = new adminCardReq();
            c.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(c);
            menu.Instance.PnlContainer.Controls["adminCardReq"].BringToFront();
        }
    }
}
