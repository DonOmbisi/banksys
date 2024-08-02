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
    public partial class totalLoans : UserControl
    {
        public totalLoans()
        {
            InitializeComponent();
        }

        private void totalLoans_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select ac_no\"A/C No\",loan_no\"Loan No\",cat\"Category\", doc\"Creation Date\", time\"Time\",rate\"Rate\",amt\"Amount\",monthly_amt\"EMI\",principal\"Principal\",verify\"Verified\",colat\"Collateral\",remarks\"Remarks\" from LOANDETAILS", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dtgv.DataSource = dtbl;
                dtgv.Refresh();
                dtgv.Update();
                info.Text = "Total No of Loans: " + dtbl.Rows.Count.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("bankInfo");
            bankInfo b = new bankInfo();
            b.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(b);
            menu.Instance.PnlContainer.Controls["bankInfo"].BringToFront();
        }
    }
}
