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
    //static fields for the tables
    

    public partial class loanReq : UserControl
    {
        public static string ac_no;
        public static string req_no;
        public static string type;
        public static string amount;
        public static string time;
        public static string proof;
        public static string  dor;
        public static string status;
        
        public loanReq()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loanReq_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select ac_no\"A/C No\",req_no\"Request No\",l_type\"Type\",l_amount\"Amount\",l_time\"Time\",l_proof\"Proof\",l_dor\"Request Date\",l_status\"Status\" from LOANREQ where l_status='PROCESSING' ", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dtgv.DataSource = dtbl;
                dtgv.Refresh();
                dtgv.Update();
            }
        }

        private void dtgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgv.Rows[e.RowIndex];
            loanReq.ac_no = row.Cells["A/C No"].Value.ToString();
            loanReq.req_no = row.Cells["Request No"].Value.ToString();
            loanReq.type = row.Cells["Type"].Value.ToString();
            loanReq.amount = row.Cells["Amount"].Value.ToString();
            loanReq.time = row.Cells["Time"].Value.ToString();
            loanReq.proof = row.Cells["Proof"].Value.ToString();
            loanReq.dor = row.Cells["Request Date"].Value.ToString().Substring(0, 11);
            loanReq.status = row.Cells["Status"].Value.ToString();
            menu.Instance.PnlContainer.Controls.RemoveByKey("adminLoanApproval");
            adminLoanApproval al = new adminLoanApproval();
            menu.Instance.PnlContainer.Controls.Add(al);
            menu.Instance.PnlContainer.Controls["adminLoanApproval"].BringToFront();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
