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
using System.Configuration;

namespace banking2
{
    public partial class passbook : UserControl
    {
        public passbook()
        {
            InitializeComponent();
        }

        private void passbook_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select dot\"Date\",trans\"Transaction\",cr_dr\"Credit/Debit\",amt\"Amount\",bal\" Balance\" from TRANS_ACTION where ac_no=@acc order by dot ", con);
                sda.SelectCommand.Parameters.AddWithValue("@acc", connection.acc_acOp);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                dtgv.DataSource = dtbl;
                dtgv.Refresh();
                dtgv.Update();
            }
                                                              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!menu.Instance.PnlContainer.Controls.ContainsKey("AccountOp"))
            {
                AccountOp a = new AccountOp();
                a.Dock = DockStyle.Fill;
                menu.Instance.PnlContainer.Controls.Add(a);

            }
            menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
