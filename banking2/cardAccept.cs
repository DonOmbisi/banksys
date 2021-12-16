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
    public partial class cardAccept : UserControl
    {
        public cardAccept()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(connection.connectionString);
                connect.Open();//close it
                SqlDataAdapter sda = new SqlDataAdapter("select ac_no from CRDREQ where ac_no=@account and provider=@prov and toc=@toc", connect);
                sda.SelectCommand.Parameters.AddWithValue("@account", acno.Text);
                sda.SelectCommand.Parameters.AddWithValue("@prov", provider.Text);
                sda.SelectCommand.Parameters.AddWithValue("@toc", type.Text);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    SqlCommand cmd1 = new SqlCommand("select c_name from CUSTOMER where ac_no=@acc ", connect);
                    cmd1.Parameters.AddWithValue("@acc", acno.Text);
                    SqlDataReader da = cmd1.ExecuteReader();
                    string name = "";
                    while (da.Read())
                    {
                        name = da.GetValue(0).ToString();
                    }

                    da.Close();
                    SqlCommand cmd = new SqlCommand("insert into CARD values(@cno,@a_c,@name,@exp,@issue,@ctg,@pro)", connect);
                    cmd.Parameters.AddWithValue("@cno",cardNo.Text);
                    cmd.Parameters.AddWithValue("@a_c", acno.Text);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@exp", expDate.Text);
                    cmd.Parameters.AddWithValue("@issue", date.Text);
                    cmd.Parameters.AddWithValue("@ctg", type.Text);
                    cmd.Parameters.AddWithValue("@pro", provider.Text);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("delete from CRDREQ where ac_no=@acco and toc=@ctgo and provider=@proo",connect);
                    cmd2.Parameters.AddWithValue("@acco",acno.Text);
                    cmd2.Parameters.AddWithValue("@ctgo", type.Text);
                    cmd2.Parameters.AddWithValue("@proo", provider.Text);
                    cmd2.ExecuteNonQuery();

                    if (MessageBox.Show("Request Accepted", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        menu.Instance.PnlContainer.Controls["cardReq"].BringToFront();
                    }

                }
                else
                {

                    warn.Visible = true;
                    warn.Text = "Request Doesn't Exists, Please first request for the card..............";
                }
                connect.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void cardNo_TextChanged(object sender, EventArgs e)
        {
            cardNo.ForeColor = Color.Black;
        }

        private void cardNo_Click(object sender, EventArgs e)
        {
            cardNo.Clear();
        }

        private void acno_Click(object sender, EventArgs e)
        {
            acno.Clear();
        }

        private void acno_TextChanged(object sender, EventArgs e)
        {
            acno.ForeColor = Color.Black;
        }
    }
}
