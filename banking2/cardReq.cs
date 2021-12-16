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
    public partial class cardReq : UserControl
    {
        public cardReq()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("applyCD");
            applyCD ap = new applyCD();
            ap.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(ap);
            menu.Instance.PnlContainer.Controls["applyCD"].BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cardAccept cr = new cardAccept();
            cr.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(cr);
            menu.Instance.PnlContainer.Controls["cardAccept"].BringToFront();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkCyan;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DarkCyan;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
    }
}
