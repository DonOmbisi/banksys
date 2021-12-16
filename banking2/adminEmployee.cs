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
    public partial class adminEmployee : UserControl
    {
        public adminEmployee()
        {
            InitializeComponent();
        }

        /*
         * This form provides the details of employee present in the bank 
         */
        private void adminEmployee_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter(" select e_username\"Username\",e_name\"Name\",e_gender\"Gender\",e_dob\"DOB\",e_email\"E-Mail\",e_phone\"Phone No\" from EMPLOYEE", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dtgv.DataSource = dtbl;
                dtgv.Refresh();
                dtgv.Update();
                info.Text = "Total No of Employees in the Bank: " + dtbl.Rows.Count.ToString();
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
