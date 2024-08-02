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
    public partial class profile : UserControl
    {
        private string pasw;
        public profile()
        {
            InitializeComponent();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select *from EMPLOYEE where e_username=@user", con);
                sda.SelectCommand.Parameters.AddWithValue("@user", connection.user);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                name.Text = dtbl.Rows[0][1].ToString();
                gender.Text = dtbl.Rows[0][3].ToString();
                DateTime da= DateTime.Parse(dtbl.Rows[0][4].ToString());
                dob.Text = da.ToString("dd'/'MM'/'yyyy");
                mail.Text = dtbl.Rows[0][5].ToString();
                phn.Text = dtbl.Rows[0][6].ToString();
                pasw = dtbl.Rows[0][2].ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);

            if (oldPass.Text == pasw)
            {
                if (pass.Text == repass.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update EMPLOYEE set e_pwd=@pwd where e_username=@user",con);
                    cmd.Parameters.AddWithValue("@pwd",repass.Text);
                    cmd.Parameters.AddWithValue("@user",connection.user);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    if (MessageBox.Show("Password Changed...", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        menu.Instance.PnlContainer.Controls["welcome"].BringToFront();
                    }
                }
                else
                {
                    warn.Visible = true;
                    warn.Text = "Please verify the Reentered Password.";
                }
            }
            else
            {
               
                    warn.Visible = true;
                    warn.Text = "Please type the correct Old Password";
                
            }
        }

        private void oldPass_Click(object sender, EventArgs e)
        {
            oldPass.Clear();
        }

        private void pass_Click(object sender, EventArgs e)
        {
            pass.Clear();
        }

        private void repass_Click(object sender, EventArgs e)
        {
            repass.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                oldPass.UseSystemPasswordChar = false;
                pass.UseSystemPasswordChar = false;
                repass.UseSystemPasswordChar = false;
            }
            else
            {
                oldPass.UseSystemPasswordChar = true;
                pass.UseSystemPasswordChar = true;
                repass.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
