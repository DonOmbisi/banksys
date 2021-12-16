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
    public partial class loanStatus : UserControl
    {
        public loanStatus()
        {
            InitializeComponent();
        }

        private void loanStatus_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            con.Open();
            if (enterLoanNo1.status=="PROCESSING")
            {
                status.Text = "PROCESSING";
                info.Text = "";

            }
            else if(enterLoanNo1.status=="APPROVED")
            {
                status.Text = "APPROVED";
                green.Visible = true;
                SqlDataAdapter sda = new SqlDataAdapter("select l.loan_no from LOANDETAILS l, LOANREQ r where l.ac_no=r.ac_no and r.req_no=@req",con);
                sda.SelectCommand.Parameters.AddWithValue("@req",enterLoanNo1.reqNo);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                info.Text = " Your Loan is Approved and Corresponding Loan No is : " + dtbl.Rows[0][0].ToString();
                con.Close();
            }
            else
            {
                status.Text = "REJECTED";
                green.Visible = false;
                red.Visible = true;
                info.Text = "Remarks Provided: "+enterLoanNo1.rem;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("enterLoanNo1");
            enterLoanNo1 la = new enterLoanNo1();
            la.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(la);
            menu.Instance.PnlContainer.Controls["enterLoanNo1"].BringToFront();
        }
    }
}
