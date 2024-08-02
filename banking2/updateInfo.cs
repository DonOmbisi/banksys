using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace banking2
{
    public partial class updateInfo : UserControl
    {
        public updateInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update CUSTOMER set c_name=@namee,c_gender=@genderr,c_dob=@dobb,c_fname=@fnamee,c_address=@adrss,c_phone=@phonee,c_email=@maill,c_aproof=@app,c_aid=@aidd,c_idproof=@ipp,c_id=@idd  where ac_no=@accc", con);
                cmd.Parameters.AddWithValue("@namee", name.Text);
                
                cmd.Parameters.AddWithValue("@genderr", gender.Text);
                cmd.Parameters.AddWithValue("@dobb", date.Text);
                cmd.Parameters.AddWithValue("@fnamee", fName.Text);
                cmd.Parameters.AddWithValue("@adrss", addrs.Text);
                cmd.Parameters.AddWithValue("@maill", mail.Text);
                cmd.Parameters.AddWithValue("@phonee", phn.Text);
                cmd.Parameters.AddWithValue("@app", aProof.Text);
                cmd.Parameters.AddWithValue("@aidd", adrsid.Text);
                cmd.Parameters.AddWithValue("@ipp", iProof.Text);
                cmd.Parameters.AddWithValue("@idd", id.Text);
                cmd.Parameters.AddWithValue("accc", connection.acc_acOp);
                try
                {
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Customer Information Updated......", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        menu.Instance.PnlContainer.Controls.RemoveByKey("AccountOp");
                        AccountOp a = new AccountOp();
                        a.Dock = DockStyle.Fill;
                        menu.Instance.PnlContainer.Controls.Add(a);
                        menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
            }
        }

        private void updateInfo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("select c_name,c_gender,c_dob,c_fname,c_address,c_phone,c_email,c_aproof,c_aid,c_idproof,c_id from CUSTOMER where ac_no=@acc", con);
                    cmd.Parameters.AddWithValue("@acc", connection.acc_acOp);
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        name.Text = da.GetValue(0).ToString();
                        gender.Text = da.GetValue(1).ToString();
                        date.Text = da.GetValue(2).ToString();
                        fName.Text = da.GetValue(3).ToString();
                        addrs.Text = da.GetValue(4).ToString();
                        phn.Text = da.GetValue(5).ToString();
                        mail.Text = da.GetValue(6).ToString();
                        aProof.Text = da.GetValue(7).ToString();
                        adrsid.Text = da.GetValue(8).ToString();
                        iProof.Text = da.GetValue(9).ToString();
                        id.Text = da.GetValue(10).ToString();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
