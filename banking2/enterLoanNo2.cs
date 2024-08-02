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
    public partial class enterLoanNo2 : UserControl
    {
        public static string loanNo;
        public static string type;
        public static string col;
        public static string doa;
        public static string acno;
        public static float amount;
        public static int time;
        public static float monthly;
        
        public enterLoanNo2()
        {
            InitializeComponent();
        }

        private void lno_TextChanged(object sender, EventArgs e)
        {
            lno.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select *from LOANDETAILS where loan_no=@l", con);
            sda.SelectCommand.Parameters.AddWithValue("@l", lno.Text);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                enterLoanNo2.loanNo =lno.Text;
                enterLoanNo2.type = dtbl.Rows[0][2].ToString();
                enterLoanNo2.col = dtbl.Rows[0][11].ToString();
                enterLoanNo2.doa = dtbl.Rows[0][3].ToString();
                enterLoanNo2.acno = dtbl.Rows[0][0].ToString();
                enterLoanNo2.amount = float.Parse(dtbl.Rows[0][7].ToString());
                enterLoanNo2.time = int.Parse(dtbl.Rows[0][5].ToString());
                enterLoanNo2.monthly = float.Parse(dtbl.Rows[0][8].ToString());
                menu.Instance.PnlContainer.Controls.RemoveByKey("loanDetails");
                loanDetails ap = new loanDetails();
                ap.Dock = DockStyle.Fill;
                menu.Instance.PnlContainer.Controls.Add(ap);
                menu.Instance.PnlContainer.Controls["loanDetails"].BringToFront();

            }
            else
            {
                warn.Visible = true;
                warn.Text = "Warning: This Loan Doesn't exist........";
            }
        }
    

        private void lno_Click(object sender, EventArgs e)
        {
            lno.Clear();
        }
    }
}
