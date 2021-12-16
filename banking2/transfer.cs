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
    public partial class transfer : UserControl
    {
        static string presentBal;
        static Boolean check=false;
        static string c_name = "";
        public transfer()
        {
            InitializeComponent();
            pBal.Text = transfer.presentBal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                
        SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TRANS_ACTION values(@ac,@trans,@amt,@dot,@balance,@cr_dr,@e_user)", con);
                cmd.Parameters.AddWithValue("@amt", float.Parse(amt3.Text));
                cmd.Parameters.AddWithValue("@dot", date.Text);
                cmd.Parameters.AddWithValue("@ac", connection.acc_acOp);
                connection c = new connection();
                cmd.Parameters.AddWithValue("@balance", c.randomBal());
                cmd.Parameters.AddWithValue("@cr_dr", "DEBIT");
                cmd.Parameters.AddWithValue("@e_user", connection.user);
                //reciever side transaction entry
                SqlCommand cmd2 = new SqlCommand("insert into TRANS_ACTION values(@acc,@transs,@amtt,@dott,@balancee,@cr_drr,@e_userr)", con);
                cmd2.Parameters.AddWithValue("@amtt", float.Parse(amt3.Text));
                cmd2.Parameters.AddWithValue("@dott", date.Text);
                cmd2.Parameters.AddWithValue("@acc",recvAcc.Text);
                cmd2.Parameters.AddWithValue("@balancee", c.randomBal());
                cmd2.Parameters.AddWithValue("@cr_drr", "CREDIT");
                cmd2.Parameters.AddWithValue("@e_userr", connection.user);
                
               
                


                if (check && (recvAcc.Text != ""))
                {
                    try
                    {
                        if (MessageBox.Show("Sender A/C No: "+connection.acc_acOp+"\n"+"Sender Name: "+AccountOp.accOpc_name+"\n"+"Reciever A/C No: "+recvAcc.Text+"\n"+"Reciever's Name:  "+c_name+"\n"+"Amount: "+amt3.Text+"\n Please Verify the Details. Is the information correct?", "Verify Details", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            
                            cmd.Parameters.AddWithValue("@trans", "Transferred To Account No: " + recvAcc.Text + " /" + transfer.c_name);
                            cmd2.Parameters.AddWithValue("@transs", "Deposited From Account No: " + connection.acc_acOp + " /" + AccountOp.accOpc_name);
                            cmd.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            

                            if (MessageBox.Show("Amount Transferred...", "Transferred", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                menu.Instance.PnlContainer.Controls.RemoveByKey("AccountOp");
                                AccountOp a = new AccountOp();
                                a.Dock = DockStyle.Fill;
                                menu.Instance.PnlContainer.Controls.Add(a);
                                menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
                            }
                        }
                        
                        
                        
                    }
                    catch(SqlException exc)
                    {
                        if(exc.Message.ToLower().Contains("check constraint"))
                            MessageBox.Show("Less Balance ........");
                       else
                            MessageBox.Show(exc.Message);

                    }
                }
                
              
                else
                {
                    if(!check)
                    {
                        warn.Visible = true;
                        warn.Text = "Warning: Please Enter valid Account No..........";
                    }
                    if(recvAcc.Text=="")
                    {
                        warn.Visible = true;
                        warn.Text = "Warning: Please Enter an Account No..........";
                    }
                }
            }


        }

        private void recvAcc_TextChanged(object sender, EventArgs e)
        {
            if(recvAcc.Text.Length==11)
            {
                SqlConnection con = new SqlConnection(connection.connectionString);
                using (con)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select ac_no,c_name,c_fname,c_phone from CUSTOMER where ac_no=@acc", con);
                    sda.SelectCommand.Parameters.AddWithValue("@acc", recvAcc.Text);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {
                        if (recvAcc.Text == connection.acc_acOp)
                        {
                            infoRecv.Visible = true;
                            infoRecv.Text = "You Cannot Transfer to your own account.....";
                            transfer.check = false;
                        }
                        else
                        {
                            infoRecv.Visible = true;
                            infoRecv.Text = "Name: " + dtbl.Rows[0][1] + "\n"+"Father's Name: " + dtbl.Rows[0][2] + "\n" + "Phone No.: " + dtbl.Rows[0][3];
                            transfer.check = true;
                            transfer.c_name = dtbl.Rows[0][1].ToString();
                        }
                    }
                   
                    else
                    {
                        infoRecv.Visible = true;
                        infoRecv.Text = "Account Do not exist......";
                        transfer.check = false;
                    }
                }
            }
        }

        private void transfer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select bal from BALANCE where ac_no = @acc", con);
                cmd1.Parameters.AddWithValue("@acc", connection.acc_acOp);
                SqlDataReader dre = cmd1.ExecuteReader();
                string temp = "";
                if (dre.Read())
                {
                    temp = dre.GetValue(0).ToString();
                }
                dre.Close();
                pBal.Text = "Present Balance: " + temp;
            }
        }

        private void recvAcc_Click(object sender, EventArgs e)
        {
            recvAcc.Clear();
            infoRecv.Text="";

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            if(!menu.Instance.PnlContainer.Controls.ContainsKey("AccountOp"))
            {
                AccountOp a = new AccountOp();
                a.Dock = DockStyle.Fill;
                menu.Instance.PnlContainer.Controls.Add(a);
                
            }
            menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
        }
    }
}
