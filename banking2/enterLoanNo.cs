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
    public partial class enterLoanNo : UserControl
    {
        public static string loanNo;
        public static string accNo;
        public static float remainAmt;
        public static float monthlyEmi;
        public static int month;
        public static int time;
        public enterLoanNo()
        {
            InitializeComponent();
        }

        private void enterLoanNo_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select *from LOANBAL where loan_no=@l", con);
            sda.SelectCommand.Parameters.AddWithValue("@l", lno.Text);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                enterLoanNo.loanNo = lno.Text;//storing account information in static variable of connection class
                enterLoanNo.accNo = dtbl.Rows[0][6].ToString();
                enterLoanNo.remainAmt = float.Parse(dtbl.Rows[0][2].ToString());
                enterLoanNo.monthlyEmi = float.Parse(dtbl.Rows[0][8].ToString());
                enterLoanNo.month = int.Parse(dtbl.Rows[0][0].ToString());
                enterLoanNo.time = int.Parse(dtbl.Rows[0][7].ToString());
                menu.Instance.PnlContainer.Controls.RemoveByKey("multipleEmi");

                multipleEmi ap = new multipleEmi();
                ap.Dock = DockStyle.Fill;
                menu.Instance.PnlContainer.Controls.Add(ap);
                menu.Instance.PnlContainer.Controls["multipleEmi"].BringToFront();

            }
            else
            {
                warn.Visible = true;
                warn.Text = "Warning: Loan Number Does not exist........";
            }
        }

        private void lno_Click(object sender, EventArgs e)
        {
            lno.Clear();
        }

        private void warn_Click(object sender, EventArgs e)
        {

        }

        private void lno_TextChanged(object sender, EventArgs e)
        {
            lno.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
