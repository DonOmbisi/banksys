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
    public partial class rejected : UserControl
    {
        public rejected()
        {
            InitializeComponent();
        }

        private void rejected_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select ac_no\"A/C No\",req_no\"Request No\",l_type\"Type\",l_amount\"Amount\",l_time\"Time\",l_proof\"Proof\",l_dor\"Request Date\",l_status\"Status\",l_remarks\"Remarks\" from LOANREQ where l_status='REJECTED' ", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dtgv.DataSource = dtbl;
                dtgv.Refresh();
                dtgv.Update();
            }
        }
    }
}
