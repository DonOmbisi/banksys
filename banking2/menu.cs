using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking2
{
    public partial class menu : Form
    {
        static menu _obj;
        public static menu Instance
        {
            get
            {
                if (_obj==null)
                {
                    _obj = new menu();
                }
                return _obj;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }

        }
        public Label lbl
        {
            get { return label; }
            set { value = label; }
        }
        public menu()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button6.Height;
            sidePanel.Top = button6.Top;
            label.Visible = false;
            if(connection.ifadmin)
            {
                panelContainer.Controls.RemoveByKey("adminLoans");
                adminLoans al = new adminLoans();
                al.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(al);
                panelContainer.Controls["adminLoans"].BringToFront();
            }
            else
            {
                panelContainer.Controls.RemoveByKey("loans");
                loans l = new loans();
                l.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(l);
                panelContainer.Controls["loans"].BringToFront();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            label.Visible = true;
            panelContainer.Controls.RemoveByKey("customer");
            customer cust = new customer();
            cust.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(cust);
            panelContainer.Controls["customer"].BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label.Visible = false;
            sidePanel.Height = button7.Height;
            sidePanel.Top = button7.Top;
            panelContainer.Controls.RemoveByKey("cardReq");
            cardReq card = new cardReq();
            card.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(card);
            panelContainer.Controls["cardReq"].BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sidePanel.Height = bankInfo.Height;
            sidePanel.Top = bankInfo.Top;
            label.Visible = false;
            panelContainer.Controls.RemoveByKey("bankInfo");
            bankInfo b = new bankInfo();
            b.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(b);
            panelContainer.Controls["bankInfo"].BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label.Visible = false;
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;
            panelContainer.Controls.RemoveByKey("enterac");
            enterac en = new enterac();
            en.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(en);
            panelContainer.Controls["enterac"].BringToFront();

        }

        private void menu_Load(object sender, EventArgs e)
        {
            _obj = this;
            welcome w = new welcome();
            w.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(w);
            panelContainer.Controls["welcome"].BringToFront();
            if(connection.ifadmin)
            {
                bankInfo.Visible = true;
                newEmp.Visible = true;
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            label.Visible = false;
            panelContainer.Controls["welcome"].BringToFront();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            label.Visible = false;
            sidePanel.Height = newEmp.Height;
            sidePanel.Top = newEmp.Top;
            panelContainer.Controls.RemoveByKey("newEmp");
            newEmp n = new newEmp();
            n.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(n);
            panelContainer.Controls["newEmp"].BringToFront();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            label.Visible = false;
            sidePanel.Height = button8.Height;
            sidePanel.Top = button8.Top;
            panelContainer.Controls.RemoveByKey("profile");
            profile n = new profile();
            n.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(n);
            panelContainer.Controls["profile"].BringToFront();
        }
    }
}
