using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace banking2
{
    public partial class enterac : UserControl
    {
        public enterac()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select *from CUSTOMER where ac_no=@account",con);
            sda.SelectCommand.Parameters.AddWithValue("@account",acno.Text);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                connection.acc_acOp = acno.Text;//storing account information in static variable of connection class
                menu.Instance.PnlContainer.Controls.RemoveByKey("AccountOp");
                
                    AccountOp ap = new AccountOp();
                    ap.Dock = DockStyle.Fill;
                    menu.Instance.PnlContainer.Controls.Add(ap);

                
                menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();

            }
            else
            {
                warn.Visible = true;
                warn.Text = "Warning: Account number Does not exist........";
            }
        }

        private void acno_Click(object sender, EventArgs e)
        {
            acno.Clear();
            warn.Visible = false;
        }

        private void acno_TextChanged(object sender, EventArgs e)
        {
            acno.ForeColor = Color.Black;
        }

        private void enterac_Load(object sender, EventArgs e)
        {

        }

        private void acno_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void acno_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
