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
    public partial class withdrawal : UserControl
    {
        

        static string presentBal = "";
        static float remBal;
        
        
        public withdrawal()
        {
            InitializeComponent();
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
                float rand =c.randomBal();
                cmd.Parameters.AddWithValue("@balance", rand);
                cmd.Parameters.AddWithValue("@cr_dr", "DEBIT");
                cmd.Parameters.AddWithValue("@e_user", connection.user);
                try
                {
                    if (medium.Text == "Through Cheque" && date.Text != "2019/10/27")
                    {
                        cmd.Parameters.AddWithValue("@trans", "WITHDRAWAL THORUGH CHEQUE NO." + cheq2.Text);

                        cmd.ExecuteNonQuery();

                        if (MessageBox.Show("Please Provide the Respective amount to the Customer.....", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            AccountOp a = new AccountOp();

                            a.myLogic();
                            menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
                        }


                    }
                    else if (medium.Text == "Form Based" && date.Text != "2019/10/27")
                    {
                        cmd.Parameters.AddWithValue("@trans", "WITHDRAWAL");

                        cmd.ExecuteNonQuery();

                        if (MessageBox.Show("Please Provide the Respective amount to the Customer.....", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            menu.Instance.PnlContainer.Controls["AccountOp"].Refresh();
                            AccountOp a = new AccountOp();
                            a.myLogic();
                            menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();//loading the accountOp form again for data grid
                        }
                    }



                    else
                    {
                        if (medium.Text == "")
                        {
                            warn.Visible = true;
                            warn.Text = "Warning: Please select an option......";
                        }
                        else if (date.Text == "2019/10/27")
                        {
                            warn.Visible = true;
                            warn.Text = "Warning: Please select an correct date......";
                        }
                    }
                }
                catch (SqlException ex)
                {

                    if (ex.Message.ToLower().Contains("check constraint"))
                        MessageBox.Show("Less Balance ........");
                    else
                        MessageBox.Show(ex.Message);
                }
            }
        }

        private void cheq2_Click(object sender, EventArgs e)
        {
            cheq2.Clear();
        }

        private void medium_Click(object sender, EventArgs e)
        {
            cheq1.Visible = false;
            cheq2.Visible = false;
            cheq3.Visible = false;
            amt1.Visible = false;
            amt2.Visible = false;
            amt3.Visible = false;
            amt4.Visible = false;
            warn.Visible = false;
            date.Visible = false;
            dLabel.Visible = false;

        }

        private void medium_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (medium.Text == "Through Cheque")
            {
                cheq1.Visible = true;
                cheq2.Visible = true;
                cheq3.Visible = true;
                amt1.Visible = true;
                amt2.Visible = true;
                amt3.Visible = true;
                amt4.Visible = true;
                dLabel.Visible = true;
                date.Visible = true;
                warn.Visible = false;
            }
            else if (medium.Text == "Form Based")
            {
                amt1.Visible = true;
                amt2.Visible = true;
                amt3.Visible = true;
                amt4.Visible = true;
                dLabel.Visible = true;
                date.Visible = true;
                warn.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls["AccountOp"].Refresh();
            AccountOp a = new AccountOp();
            a.myLogic();
            menu.Instance.PnlContainer.Controls["AccountOp"].BringToFront();
        }

        private void withdrawal_Load(object sender, EventArgs e)
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
                withdrawal.presentBal = temp;
                pBal.Text = "Present Balance: " + temp;
            }
        }
        
    }
}

