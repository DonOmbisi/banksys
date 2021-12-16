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
    public partial class todayLoan : UserControl
    {
        public todayLoan()
        {
            InitializeComponent();
        }

        private void todayLoan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select loan_no\"Loan No\",ac_no\"A/C No\",fault\"Issue\",dof\"On Date\" from DEFAULTERS ", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dtgv.DataSource = dtbl;
                
            }

        }
    }
}
