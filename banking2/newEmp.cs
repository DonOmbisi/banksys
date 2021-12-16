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
    public partial class newEmp : UserControl
    {
        Boolean a = false;
        static Boolean passCheck = false;
        public newEmp()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            try
            {
                using (con)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select e_username from EMPLOYEE where e_username=@usr", con);
                    sda.SelectCommand.Parameters.AddWithValue("@usr", userid.Text);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    this.check();
                    if (a && date.Text!="2019/10/28")
                    {
                        warn.Visible = true;
                        warn.Text = "Please fill all the fields....";
                    }
                    else if (newEmp.passCheck)
                    {
                        SqlCommand cmd = new SqlCommand("insert into EMPLOYEE values(@user,@name,@pwd,@gender,@dob,@mail,@phone)", con);
                        cmd.Parameters.AddWithValue("@user", userid.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@pwd", repass.Text);
                        cmd.Parameters.AddWithValue("@gender", gender.Text);
                        cmd.Parameters.AddWithValue("@dob", date.Text);
                        cmd.Parameters.AddWithValue("@mail", mail.Text);
                        cmd.Parameters.AddWithValue("@phone", phn.Text);
                        cmd.ExecuteNonQuery();
                        if (MessageBox.Show("Employee Registered......", "Registeration", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            menu.Instance.PnlContainer.Controls.RemoveByKey("welcome");
                            welcome w = new welcome();
                            menu.Instance.PnlContainer.Controls.Add(w);
                            menu.Instance.PnlContainer.Controls["welcome"].BringToFront();
                        }

                    }
                    else
                    {
                        warn.Visible = true;
                        warn.Text = "Warning: Please check the Passwords......";
                    }

                }
            }
            catch (Exception f)
            {
                if (f.Message.ToLower().Contains("primary key"))
                {
                    warn.Visible = true;
                    warn.Text = "Warning: Please choose another user id.........";
                }
                else
                {
                    MessageBox.Show(f.Message);
                }
            }
        }
        public void check()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        this.a = true;
                    }

                }
            }
        }

        private void userid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            if (userid.Text.Length >= 5)
            {
               
                    using (con)
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("select e_username from EMPLOYEE where e_username=@usr", con);
                        sda.SelectCommand.Parameters.AddWithValue("@usr", userid.Text);
                        DataTable dtbl = new DataTable();
                        sda.Fill(dtbl);
                        if (dtbl.Rows.Count == 1)
                        {
                            userwarn.Visible = true;
                            userwarn.Text = "Please choose another user id.........";
                        }
                    }
                
             }
            else
            {
                userwarn.Visible = false;
            }
        }

        private void newEmp_Load(object sender, EventArgs e)
        {

        }

        private void repass_TextChanged(object sender, EventArgs e)
        {
            if (repass.Text.Length == pass.Text.Length)
            {
                if (repass.Text == pass.Text)
                {
                    newEmp.passCheck = true;
                    warn.Visible = false;

                }
                else
                {
                    newEmp.passCheck = false;
                    warn.Visible = true;
                    warn.Text = "Warning: Please check the Passwords......";
                }
            }
            else if(repass.Text.Length>pass.Text.Length)
            {
                newEmp.passCheck = false;
                warn.Visible = true;
                warn.Text = "Warning: Please check the Passwords......";
            }
            else
            {
                newEmp.passCheck = false;
                warn.Visible = false;
            }
        }

        private void name_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            name.Clear();
        }

        private void mail_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            mail.Clear();
        }

        private void phn_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            phn.Clear();
        }

        private void userid_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            userid.Clear();
            userwarn.Visible = false;
        }

        private void pass_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            pass.Clear();
        }

        private void repass_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            repass.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
                repass.UseSystemPasswordChar = false;

            }
            else
            {
                pass.UseSystemPasswordChar = true;
                repass.UseSystemPasswordChar = true;
            }
        }
    }
    
}
