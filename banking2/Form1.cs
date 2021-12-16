using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace banking2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /* Authentication Here */
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            try
            {
                using (con)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select e_username from EMPLOYEE where e_username=@user and e_pwd=@pwd", con);
                    sda.SelectCommand.Parameters.AddWithValue("@user", username.Text);
                    sda.SelectCommand.Parameters.AddWithValue("@pwd", password.Text);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {
                        if (username.Text == "admin")
                        {
                            connection.ifadmin = true;
                            connection.user = username.Text;
                            menu m = new menu();
                            m.Show();
                            this.Hide();
                        }
                        else
                        {
                            connection.ifadmin = false;
                            connection.user = username.Text;
                            menu m = new menu();
                            m.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        if (MessageBox.Show("Invalid Username or Password, Please Try Again...!!!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            username.Clear();
                            password.Clear();
                            

                        }
                       
                    }
                }
            }
            catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void username_Click(object sender, EventArgs e)
        {
            username.Clear();
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            //DateTime answer = d.AddDays(Convert.ToInt32("31"));
            string date = d.ToString("yyyy'/'MM'/'dd");


            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from LOANBAL where next_payment=@next", con);
                sda.SelectCommand.Parameters.AddWithValue("@next", date);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                



                
                if (dtbl.Rows.Count >= 1)
                {
                    for (int i = 0; i < dtbl.Rows.Count; i++)
                    {
                        SqlCommand cmd = new SqlCommand("Update LOANBAL set month=@month,rem_loan=@rem,paid_on=@paidDate,next_payment=@next,amount=@amt where loan_no=@loanNo", con);
                        cmd.Parameters.AddWithValue("@month", int.Parse(dtbl.Rows[i][0].ToString()) + 1);
                        cmd.Parameters.AddWithValue("@rem", float.Parse(dtbl.Rows[i][2].ToString()) - float.Parse(dtbl.Rows[i][8].ToString()));
                        cmd.Parameters.AddWithValue("@paidDate", dtbl.Rows[i][4]);
                        cmd.Parameters.AddWithValue("@loanNo",dtbl.Rows[i][1].ToString());

                        DateTime today = DateTime.Parse(dtbl.Rows[i][4].ToString());
                        DateTime answer1 = today.AddDays(Convert.ToInt32("31"));
                        string next = answer1.ToString("yyyy'/'MM'/'dd");
                        cmd.Parameters.AddWithValue("@next", next);
                        cmd.Parameters.AddWithValue("@amt", float.Parse(dtbl.Rows[i][8].ToString()));

                        SqlCommand cmd1 = new SqlCommand("insert into TRANS_ACTION values(@ac_no,@trans,@amt,@dot,@bal,@cr_dr,@user)", con);
                        cmd1.Parameters.AddWithValue("@ac_no", dtbl.Rows[i][6].ToString());
                        cmd1.Parameters.AddWithValue("@trans", "LOAN DEPOSITON");
                        cmd1.Parameters.AddWithValue("@amt", float.Parse(dtbl.Rows[i][8].ToString()));
                        cmd1.Parameters.AddWithValue("@dot", dtbl.Rows[i][4]);
                        connection c = new connection();

                        cmd1.Parameters.AddWithValue("@bal", c.randomBal());
                        cmd1.Parameters.AddWithValue("@cr_dr", "DEBIT");
                        cmd1.Parameters.AddWithValue("@user", "admin");

                        SqlCommand cmd2 = new SqlCommand("Delete from LOANBAL where loan_no=@loan and ac_no =@ac",con);
                        cmd2.Parameters.AddWithValue("@loan", dtbl.Rows[i][1].ToString());
                        cmd2.Parameters.AddWithValue("@ac", dtbl.Rows[i][6].ToString());

                        SqlCommand cmd3 = new SqlCommand("Delete from LOANDETAILS where loan_no=@loan and ac_no =@ac",con);
                        cmd3.Parameters.AddWithValue("@loan", dtbl.Rows[i][1].ToString());
                        cmd3.Parameters.AddWithValue("@ac", dtbl.Rows[i][6].ToString());

                        SqlCommand cmd4 = new SqlCommand("update LOANREQ set l_status='COMPLETED' where l_status='APPROVED' and ac_no =@ac", con);
                        cmd4.Parameters.AddWithValue("@ac", dtbl.Rows[i][6].ToString());


                        try
                        {
                            if ((int.Parse(dtbl.Rows[i][0].ToString()) + 1) == (int.Parse(dtbl.Rows[i][7].ToString())))
                            {
                                cmd2.ExecuteNonQuery();
                                cmd3.ExecuteNonQuery();
                                cmd4.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd1.ExecuteNonQuery();
                                cmd.ExecuteNonQuery();
                                

                            }
                        }
                        catch(Exception ex)
                        {
                           if(ex.Message.ToLower().Contains("check constraint"))
                            {
                                try
                                {
                                    SqlCommand cmd5 = new SqlCommand("insert into DEFAULTERS values(@l,@a,@f,@d) ", con);
                                    cmd5.Parameters.AddWithValue("@l", dtbl.Rows[i][1].ToString());
                                    cmd5.Parameters.AddWithValue("@a", dtbl.Rows[i][6].ToString());
                                    cmd5.Parameters.AddWithValue("@f", "Account Balance Low.....Loan EMI couldn't be paid, Please contact customer");
                                    cmd5.Parameters.AddWithValue("@d", dtbl.Rows[i][4]);
                                    cmd5.ExecuteNonQuery();
                                    
                                }
                                catch(Exception exc)
                                {
                                    if(exc.Message.ToLower().Contains("primary key"))
                                    {
                                        SqlCommand cmd7 = new SqlCommand("update DEFAULTERS set dof=@d where loan_no=@l",con);
                                        cmd7.Parameters.AddWithValue("@d",dtbl.Rows[i][4]);
                                        cmd7.Parameters.AddWithValue("@l", dtbl.Rows[i][1]);
                                        cmd7.ExecuteNonQuery();
                                    }
                                }
                                finally
                                {
                                    SqlCommand cmd6 = new SqlCommand("update LOANBAL set paid_on=@p,next_payment=@n where loan_no=@l", con);
                                    cmd6.Parameters.AddWithValue("@p", dtbl.Rows[i][4]);
                                    cmd6.Parameters.AddWithValue("@n", next);
                                    cmd6.Parameters.AddWithValue("@l", dtbl.Rows[i][1].ToString());
                                    cmd6.ExecuteNonQuery();
                                }
                            }
                            else
                                MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
