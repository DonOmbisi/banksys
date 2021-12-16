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
    public partial class multipleEmi : UserControl
    {
        
        public multipleEmi()
        {
            InitializeComponent();
        }

        private void pBal_Click(object sender, EventArgs e)
        {

        }

        private void multipleEmi_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select bal from BALANCE where ac_no = @acc", con);
                cmd1.Parameters.AddWithValue("@acc",enterLoanNo.accNo);//provide account no here 
                SqlDataReader dre = cmd1.ExecuteReader();
                string temp = "";
                if (dre.Read())
                {
                    temp = dre.GetValue(0).ToString();
                }
                dre.Close();
                pBal.Text = "Present Account Balance: " + temp+"\n"+"Assosiated Account No: "+enterLoanNo.accNo
                    +"\n"+"Loan No.: "+enterLoanNo.loanNo;
                temp1.Text = "Remaining Loan Amount: "+enterLoanNo.remainAmt+" Rs"+"\n"+"Monthly EMI : "+enterLoanNo.monthlyEmi+" Rs";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            using (con)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into TRANS_ACTION values(@ac,@ts,@amt,@dot,@bal,'DEBIT','admin')", con);
                cmd1.Parameters.AddWithValue("@ac", enterLoanNo.accNo);
                
                cmd1.Parameters.AddWithValue("@dot",date.Text );
                cmd1.Parameters.AddWithValue("@ts", "MULTIPLE LOAN DEDUCTON");
                connection c = new connection();
                cmd1.Parameters.AddWithValue("@bal",c.randomBal());
                

                SqlCommand cmd2 = new SqlCommand("update LOANBAL set month=@m,rem_loan=@r,paid_on=@p,amount=@a where loan_no=@lo", con);
                cmd2.Parameters.AddWithValue("@lo", enterLoanNo.loanNo);
                cmd2.Parameters.AddWithValue("@p", date.Text);



                int x = (int)((float.Parse(amount.Text)) / enterLoanNo.monthlyEmi);//time came according to the 
                int diff = enterLoanNo.time - enterLoanNo.month;
                if(x>=diff)
                {
                    float tocut = enterLoanNo.monthlyEmi * diff;
                    //debit from TRANS_ACTION using sql
                    float remBal = 0F;
                    int newTime = enterLoanNo.time;
                    int remEmi = 0;
                    cmd1.Parameters.AddWithValue("@amt", tocut);
                   
                    cmd2.Parameters.AddWithValue("@m", newTime);
                    cmd2.Parameters.AddWithValue("@r", remBal);
                    cmd2.Parameters.AddWithValue("@a", tocut);
                    try
                    {
                        if (amount.Text != "" && date.Text != "2019/10/27")
                        {

                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            if (MessageBox.Show("Remaning Time: "+remEmi.ToString()+" months"+"\n"+"Remaining Loan Amount: "+remBal.ToString()+" Rs"+"\n"+"Amount Deposited: "+tocut+" Rs", "Loan Amount Deposited", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                menu.Instance.PnlContainer.Controls.RemoveByKey("adminLoans");
                                adminLoans w = new adminLoans();
                                w.Dock = DockStyle.Fill;
                                menu.Instance.PnlContainer.Controls.Add(w);
                                menu.Instance.PnlContainer.Controls["adminLoans"].BringToFront();

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.ToLower().Contains("check constraint"))
                            warn.Text = "Warning: Please provide Amount lesser than the amount available in the account. Or u can deposit money then try..";
                        MessageBox.Show(ex.Message);
                    }
                }
                else if(x<diff)
                {
                    float tocut = enterLoanNo.monthlyEmi * x;
                    //debit from TRANSACTION using sql
                    float rembal = enterLoanNo.remainAmt - tocut;
                    int newTime = enterLoanNo.month + x;
                    int remEmi = enterLoanNo.time - newTime;
                    cmd1.Parameters.AddWithValue("@amt", tocut);
                    cmd2.Parameters.AddWithValue("@m", newTime);
                    cmd2.Parameters.AddWithValue("@r", rembal);
                    cmd2.Parameters.AddWithValue("@a", tocut);
                    try
                    {
                        if (amount.Text != "" && date.Text != "2019/10/27")
                        {

                            cmd1.ExecuteNonQuery();
                            cmd2.ExecuteNonQuery();
                            if (MessageBox.Show("Remaining Time: "+remEmi+" months"+"\n"+"Remaining Loan Amount: "+rembal+" Rs"+"\n"+"Amount Deposited: "+tocut+" Rs","Loan Amount Deposited", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                menu.Instance.PnlContainer.Controls.RemoveByKey("adminLoans");
                                adminLoans w = new adminLoans();
                                w.Dock = DockStyle.Fill;
                                menu.Instance.PnlContainer.Controls.Add(w);
                                menu.Instance.PnlContainer.Controls["adminLoans"].BringToFront();

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
               
                
                

                

                




            }
        }
    }
}
