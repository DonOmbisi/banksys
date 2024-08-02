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
    public partial class customers : UserControl
    {
        public customers()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select ac_no\"A/C No\",c_name\"Customer Name\",c_gender\"Gender\",c_dob\"DOB\",c_address\"Address\",c_phone\"Phone\",c_email\"E-Mail\",c_aproof\"Address Proof\",c_aid\"Address ID\",c_idproof\"Id Proof\",c_id\"Id No\",e_username\"Made By\",c_doc\"Created On\",c_startBal\"Starting Balance\",c_salaried\"If Salary Account\" from CUSTOMER ", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dtgv.DataSource = dtbl;
                dtgv.Refresh();
                dtgv.Update();
                info.Text = "Total No of Customers in the Bank: " + dtbl.Rows.Count.ToString();
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
