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
    public partial class enterLoanNo1 : UserControl
    {
        public static string status;
        public static string reqNo;
        public static string rem;
        public enterLoanNo1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select *from LOANREQ where req_no=@l", con);
            sda.SelectCommand.Parameters.AddWithValue("@l", lno.Text);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                enterLoanNo1.status = dtbl.Rows[0][7].ToString();
                enterLoanNo1.reqNo = lno.Text;
                enterLoanNo1.rem = dtbl.Rows[0][8].ToString();

                menu.Instance.PnlContainer.Controls.RemoveByKey("loanStatus");
                loanStatus la = new loanStatus();
                la.Dock = DockStyle.Fill;
                menu.Instance.PnlContainer.Controls.Add(la);
                menu.Instance.PnlContainer.Controls["loanStatus"].BringToFront();


            }
            else
            {
                warn.Visible = true;
                warn.Text = "Warning: Loan Request Number Does not exist........";
            }
        }

        private void lno_TextChanged(object sender, EventArgs e)
        {
            lno.ForeColor = Color.Black;
        }

        private void lno_Click(object sender, EventArgs e)
        {
            lno.Clear();
        }
    }
}
