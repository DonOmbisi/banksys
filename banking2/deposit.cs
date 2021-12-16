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
    public partial class deposit : UserControl
    {
        static string presentBal = "";
        
        public deposit()
        {
            InitializeComponent();
        }

        private void amt2_Click(object sender, EventArgs e)
        {

        }

        private void amt4_Click(object sender, EventArgs e)
        {

        }

        private void amt3_Click(object sender, EventArgs e)
        {
            warn.Visible = false;
            amt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();

                //call to withdraw method.
                SqlCommand cmd = new SqlCommand("insert into TRANS_ACTION values(@ac,@trans,@amt,@dot,@balance,@cr_dr,@e_user)", con);
                cmd.Parameters.AddWithValue("@amt", float.Parse(amt.Text));
                cmd.Parameters.AddWithValue("@dot", date.Text);
                cmd.Parameters.AddWithValue("@ac", connection.acc_acOp);//get the account no 
                connection c = new connection();
                float rand = c.randomBal();
                cmd.Parameters.AddWithValue("@balance", rand);
                //add trans value according to the if and else condition
                cmd.Parameters.AddWithValue("@cr_dr", "CREDIT");
                cmd.Parameters.AddWithValue("@e_user", connection.user);
                if ((amt.Text!="") && (date.Text!= "2019/10/27"))
                {
                    cmd.Parameters.AddWithValue("@trans", "DEPOSIT");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                                   
                    catch (SqlException ex)
                    {

                        if (ex.Message.ToLower().Contains("check constraint"))
                            MessageBox.Show("Less Balance ........");
                        else
                            MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (MessageBox.Show("Amount Updated.......", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            
                            AccountOp a = new AccountOp();
                            a.myLogic();
                            menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
                        }
                    }
                }
               
                else
                {
                    if (amt.Text == "")
                    {
                        warn.Visible = true;
                        warn.Text = "Warning: Please enter an amount......";
                    }
                    else if (date.Text== "2019/10/27")
                    {
                        warn.Visible = true;
                        warn.Text = "Warning: Please select an correct date......";
                    }
                }
            }
        }
       

        private void deposit_Load(object sender, EventArgs e)
        {
            //for showing present balance
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

        private void button3_Click(object sender, EventArgs e)
        {
            AccountOp a = new AccountOp();
            a.myLogic();
            menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
        }
    }
}
