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
using System.Globalization;

namespace banking2
{
    /*
     * This form allows a employee to verify particular loan number and provided documentation. 
     * And approve or diapprove the loan
     */
    public partial class adminLoanApproval : UserControl
    {
        static string loanNo;
        static float rate;
        public adminLoanApproval()
        {
            InitializeComponent();
        }

        private void adminLoanApproval_Load(object sender, EventArgs e)
        {
            type.Text = loanReq.type;
            proof.Text = loanReq.proof;
            req_no.Text = loanReq.req_no;
            date.Text = loanReq.dor;
            account.Text = loanReq.ac_no;
            amt.Text = loanReq.amount + " Rs";
            time.Text = loanReq.time + " months";
            status.Text = loanReq.status;
            switch (type.Text)
            {
                case "Car Loan":
                    adminLoanApproval.rate = 8.70F;
                    adminLoanApproval.loanNo = "C";
                    break;
                case "Home Loan":
                    adminLoanApproval.rate = 8.50F;
                    adminLoanApproval.loanNo = "H";
                    break;
                case "Agriculture Loan":
                    adminLoanApproval.rate = 7.00F;
                    adminLoanApproval.loanNo = "A";
                    break;
                case "Student Loan":
                    adminLoanApproval.rate = 9.75F;
                    adminLoanApproval.loanNo = "S";
                    break;
                case "Jewellery Loan":
                    adminLoanApproval.rate = 11.05F;
                    adminLoanApproval.loanNo = "J";
                    break;
                case "Bussiness Loan":
                    adminLoanApproval.rate = 11.20F;
                    adminLoanApproval.loanNo = "B";
                    break;
            }
            

            
            
            SqlConnection con = new SqlConnection(connection.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select *from CUSTOMER where ac_no=@account", con);
            sda.SelectCommand.Parameters.AddWithValue("@account", account.Text);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            SqlDataAdapter sda1 = new SqlDataAdapter("Select * from LOANDETAILS where ac_no=@acc",con);
            sda1.SelectCommand.Parameters.AddWithValue("@acc",account.Text);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            if (dtbl.Rows.Count == 1)
            {
                if (dtbl.Rows[0][15].ToString() == "Yes")
                {
                    green.Visible = true;
                    acInfo.Visible = true;
                    red.Visible = false;
                    acInfo.Text ="This account is SALARY ACCOUNT"+"\n"+"Name: " + dtbl.Rows[0][1] + "\n"
                        + "Gender: " + dtbl.Rows[0][2] + "\n"
                        + "Id Proof: " + dtbl.Rows[0][10] + "\n"
                        + "Identification No,: " + dtbl.Rows[0][11];
                }
                else
                {
                    green.Visible = false;
                    acInfo.Visible = true;
                    red.Visible = true;
                    acInfo.Text = "This account is NOT SALARY ACCOUNT" + "\n" + "Name: " + dtbl.Rows[0][1] + "\n"
                        + "Gender: " + dtbl.Rows[0][2] + "\n"
                        + "Id Proof: " + dtbl.Rows[0][10] + "\n"
                        + "Identification No,: " + dtbl.Rows[0][11];
                }
                if(dtbl1.Rows.Count==1)
                {
                    acInfo.Text = acInfo.Text + "\n"
                        + "Assosiated Loans: "+dtbl1.Rows[0][2]+"\n"
                        +"Loan No: " + dtbl1.Rows[0][1];
                }
                else
                {
                    acInfo.Text = acInfo.Text + "\n"
                        + "No Loans Assosiated with this account.";
                }



            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void amt1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            
            using (con)
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LOANREQ set l_status=@stats,l_remarks=@remarks where req_no=@acc",con);
                cmd.Parameters.AddWithValue("@acc",req_no.Text);
                
                
               
                float total_amt;
                float t = float.Parse(loanReq.time) / 12;
                float principal = float.Parse(loanReq.amount);
                total_amt = (float)(principal*Math.Pow((1 + (adminLoanApproval.rate/100)), t));
                float monthly = total_amt / (int.Parse(loanReq.time));

                
                DateTime today = DateTime.Parse(date1.Text);
                DateTime answer = today.AddDays(Convert.ToInt32("31"));
                string next = answer.ToString("yyyy'/'MM'/'dd");

                SqlCommand cmd1 = new SqlCommand("loanDetailsInsertion",con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@ac_no", SqlDbType.VarChar).Value =account.Text;
                cmd1.Parameters.Add("@cat", SqlDbType.VarChar).Value = type.Text;
                cmd1.Parameters.Add("@doc", SqlDbType.Date).Value = date1.Text;
                cmd1.Parameters.Add("@next_date", SqlDbType.Date).Value = next;
                cmd1.Parameters.Add("@time", SqlDbType.Int).Value =int.Parse(loanReq.time) ;
                cmd1.Parameters.Add("@rate", SqlDbType.Float).Value = adminLoanApproval.rate;
                cmd1.Parameters.Add("@amt", SqlDbType.Float).Value = float.Parse(loanReq.amount);
                cmd1.Parameters.Add("@monthly_amt", SqlDbType.Float).Value = monthly;
                cmd1.Parameters.Add("@principal", SqlDbType.Float).Value = total_amt;
                cmd1.Parameters.Add("@verify", SqlDbType.VarChar).Value = "Yes";
                cmd1.Parameters.Add("@colat", SqlDbType.VarChar).Value = proof.Text;
                cmd1.Parameters.Add("@remarks", SqlDbType.VarChar).Value = rem.Text;
                cmd1.Parameters.Add("@loanreq",SqlDbType.VarChar).Value=req_no.Text;
                connection c = new connection();
                cmd1.Parameters.Add("@random",SqlDbType.Float).Value=c.randomBal();
                cmd1.Parameters.Add("@loan", SqlDbType.VarChar).Value = adminLoanApproval.loanNo+req_no.Text;
               
                

                try
                {
                    if (yes.Checked==true && status.Text=="APPROVED" && date1.Text!="2019/10/27")
                    {
                        
                        if (MessageBox.Show("Are you sure about approving the loan?", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            cmd.Parameters.AddWithValue("@stats", "APPROVED");
                            cmd.Parameters.AddWithValue("@remarks", "");
                            cmd.ExecuteNonQuery();
                            cmd1.ExecuteNonQuery();
                            menu.Instance.PnlContainer.Controls.RemoveByKey("loanReq");
                            loanReq lr = new loanReq();
                            menu.Instance.PnlContainer.Controls.Add(lr);
                            menu.Instance.PnlContainer.Controls["loanReq"].BringToFront();
                        }
                        warn.Visible = false;
                    }
                    else if(yes.Checked==true && status.Text=="REJECTED" && date1.Text!="2019/10/28")
                    {
                        if (MessageBox.Show("Are you sure about rejecting the loan?", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            cmd.Parameters.AddWithValue("@stats", "REJECTED");
                            cmd.Parameters.AddWithValue("@remarks", rem.Text);
                            cmd.ExecuteNonQuery();
                            menu.Instance.PnlContainer.Controls.RemoveByKey("loanReq");
                            loanReq lr = new loanReq();
                            menu.Instance.PnlContainer.Controls.Add(lr);
                            menu.Instance.PnlContainer.Controls["loanReq"].BringToFront();
                        }
                        warn.Visible = false;
                    }
                    else
                    {
                        if(no.Checked==true)
                        {
                            warn.Visible = true;
                            warn.Text = "Please Verify the Documents first....";
                        }
                        else if(date1.Text=="2019/10/28")
                        {
                            warn.Visible = true;
                            warn.Text = "Please Check the Today date.......";
                        }
                        else if(status.Text=="PROCESSING")
                        {
                            warn.Visible = true;
                            warn.Text = "Please either REJECT the loan or APPROVE the loan or go back";
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    if (ex.Message.ToLower().Contains("input string"))
                    {
                        warn.Visible = true;
                        warn.Text = "Please provide all the above said values";
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }




            }

        }
        
    }
}
