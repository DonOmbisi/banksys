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
    public partial class applyCD : UserControl
    {
        public applyCD()
        {
            InitializeComponent();
        }

        private void warn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(connection.connectionString);
                connect.Open();//close it
                SqlDataAdapter sda = new SqlDataAdapter("select c_name from CUSTOMER where ac_no=@account", connect);
                sda.SelectCommand.Parameters.AddWithValue("@account", acno.Text);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    SqlCommand cmd1 = new SqlCommand("select c_name from CUSTOMER where ac_no=@acc ", connect);
                    cmd1.Parameters.AddWithValue("@acc", acno.Text);
                    SqlDataReader da = cmd1.ExecuteReader();
                    string name="";
                    while (da.Read())
                    {
                        name = da.GetValue(0).ToString();
                    }
                    
                    da.Close();
                    SqlCommand cmd = new SqlCommand("insert into CRDREQ values(@acco,@toc,@pro,@dor,@name)", connect);
                    cmd.Parameters.AddWithValue("@acco", acno.Text);
                    cmd.Parameters.AddWithValue("@toc", type.Text);
                    cmd.Parameters.AddWithValue("@pro", pro.Text);
                    cmd.Parameters.AddWithValue("@dor", date.Text);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    if (MessageBox.Show("Request Accepted", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        menu.Instance.PnlContainer.Controls["cardReq"].BringToFront();
                    }

                }
                else
                {

                    warn.Visible = true;
                    warn.Text = "Warning: Account Number Doesn't Exists..........";
                }
                connect.Close();
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls["cardReq"].BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void acno_Click(object sender, EventArgs e)
        {
            acno.Clear();
        }

        private void applyCD_Load(object sender, EventArgs e)
        {

        }

        private void acno_TextChanged(object sender, EventArgs e)
        {
            acno.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
