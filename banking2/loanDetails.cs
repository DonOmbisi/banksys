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
    public partial class loanDetails : UserControl
    {
        public loanDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("enterLoanNo2");
            enterLoanNo2 la = new enterLoanNo2();
            la.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(la);
            menu.Instance.PnlContainer.Controls["enterLoanNo2"].BringToFront();
        }

        private void loanDetails_Load(object sender, EventArgs e)
        {
            loanNo.Text = enterLoanNo2.loanNo;
            type.Text = enterLoanNo2.type;
            proof.Text = enterLoanNo2.col;
            date.Text = enterLoanNo2.doa.Substring(0,10);
            account.Text = enterLoanNo2.acno;
            amt.Text = enterLoanNo2.amount.ToString()+" Rs";
            time.Text = enterLoanNo2.time.ToString()+" month";
            monthly.Text = enterLoanNo2.monthly.ToString()+" Rs";
            SqlConnection con = new SqlConnection(connection.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select *from LOANBAL where loan_no=@l", con);
            sda.SelectCommand.Parameters.AddWithValue("@l", loanNo.Text);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                date1.Text = dtbl.Rows[0][4].ToString().Substring(0,10);
                rAmt.Text = dtbl.Rows[0][2].ToString()+" Rs";
                cemi.Text = dtbl.Rows[0][0].ToString();
                int rem = int.Parse(dtbl.Rows[0][7].ToString())-int.Parse(dtbl.Rows[0][0].ToString());
                rTime.Text = rem.ToString()+" month";

            }
           

        }
    }
}
