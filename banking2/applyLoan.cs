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
    public partial class applyLoan : UserControl
    {
        static float rate;
        static string loanNo;
        static Boolean check ;
        static Boolean check1;
        static Boolean check2;
        public static string reqnum;
        public applyLoan()
        {
            InitializeComponent();
        }

        private void medium_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaninfo.Visible = false;

            //give interest values here
            switch(loanType.Text)
            {
                case "Car Loan": applyLoan.rate = 8.70F;
                    applyLoan.loanNo = "C";
                     break;
                case "Home Loan":applyLoan.rate = 8.50F;
                    applyLoan.loanNo = "H";
                    break;
                case "Agriculture Loan": applyLoan.rate = 7.00F;
                    applyLoan.loanNo = "A";
                    break;
                case "Student Loan":applyLoan.rate = 9.75F;
                    applyLoan.loanNo = "S";
                    break;
                case "Jewellery Loan":applyLoan.rate = 11.05F;
                    applyLoan.loanNo = "J";
                    break;
                case "Bussiness Loan": applyLoan.rate = 11.20F;
                    applyLoan.loanNo = "B";
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            if (time.Text!="")
            {
                if (int.Parse(time.Text) > 0)
                {
                    float total_amt;
                    float t = float.Parse(time.Text) / 12;
                    float principal = float.Parse(amt.Text);
                    total_amt = (float)(principal * Math.Pow((1 + (applyLoan.rate / 100)), t));

                    float monthly_min = total_amt / (t * 12);
                    loaninfo.Visible = true;
                    loaninfo.Text = "LOAN AMOUNT: " + amt.Text + "\n"
                        + "AMOUNT TO BE PAID: " + total_amt.ToString("0.00") + "\n"
                        + "RATE: " + applyLoan.rate.ToString() + "\n"
                        + "MIN MONTHLY AMOUNT TO BE PAID: " + monthly_min.ToString("0.00");
                    applyLoan.check = true;
                }
                else
                {
                    loaninfo.Text = "Invalid Input....";
                    applyLoan.check = false;

                }
            }
            else
            {
                loaninfo.Text = "";
                applyLoan.check = false;
            }
        }

        private void applyLoan_Load(object sender, EventArgs e)
        {
            loaninfo.Visible = false;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            
                SqlConnection con = new SqlConnection(connection.connectionString);
             using (con)
                {
                try
                {
                    con.Open();
                SqlCommand cmd = new SqlCommand("insert into LOANREQ values(@ac,@req_no,@type,@amt,@time,@proof,@dor,@status,@rem)", con);
                cmd.Parameters.AddWithValue("@ac",acc.Text);
                
                    applyLoan.reqnum = checkAc();
                    cmd.Parameters.AddWithValue("@req_no", reqnum);
                    cmd.Parameters.AddWithValue("@type", loanType.Text);
                    cmd.Parameters.AddWithValue("@amt", float.Parse(amt.Text));
                    cmd.Parameters.AddWithValue("@time", int.Parse(time.Text));
                    if (col.Text == "Others")
                        cmd.Parameters.AddWithValue("@proof", oth1.Text);
                    else
                        cmd.Parameters.AddWithValue("@proof", col.Text);
                    cmd.Parameters.AddWithValue("@dor", date.Text);
                    cmd.Parameters.AddWithValue("@status", "PROCESSING");
                    cmd.Parameters.AddWithValue("@rem", "NULL");




                    if (applyLoan.check && applyLoan.check1 && date.Text != "2019/10/27")
                    {


                        cmd.ExecuteNonQuery();
                        if (MessageBox.Show("Requested Accepted....", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            menu.Instance.PnlContainer.Controls.RemoveByKey("loanApproved");
                            loanApproved la = new loanApproved();
                            la.Dock = DockStyle.Fill;
                            menu.Instance.PnlContainer.Controls.Add(la);
                            menu.Instance.PnlContainer.Controls["loanApproved"].BringToFront();
                        }


                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.ToLower().Contains("input string"))
                    {
                        warn.Visible = true;
                        warn.Text = "Please verify the filled details.......";
                    }
                    else if (ex.Message.ToLower().Contains("primary key"))
                    {
                        warn.Visible = true;
                        warn.Text = "Sorry, this Account allready have a Loan assosiated with it.....";
                    }
                    else
                    {
                        warn.Visible = false;
                        MessageBox.Show(ex.Message);
                    }

                }
             }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(col.Text=="Others")
            {
                oth.Visible = true;
                oth1.Visible = true;
            }
            else
            {
                oth.Visible = false;
                oth1.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(acc.Text.Length==11)
            {
                SqlConnection con = new SqlConnection(connection.connectionString);
                SqlDataAdapter sda = new SqlDataAdapter("Select *from CUSTOMER where ac_no=@account", con);
                sda.SelectCommand.Parameters.AddWithValue("@account", acc.Text);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    if (dtbl.Rows[0][15].ToString() == "Yes")
                    {
                        green.Visible = true;
                        acInfo.Visible = true;
                        red.Visible = false;
                        acInfo.ForeColor = Color.Green;

                        acInfo.Text = "Name: " + dtbl.Rows[0][1] + "\n"
                            + "Gender: " + dtbl.Rows[0][2] + "\n"
                            + "Id Proof: " + dtbl.Rows[0][10] + "\n"
                            + "Identification No,: " + dtbl.Rows[0][11];
                    }
                    else
                    {
                        green.Visible = false;
                        acInfo.ForeColor = Color.Red;
                        red.Visible = true;
                        acInfo.Visible = true;
                        acInfo.Text = "This Account is not a Salary Account.";

                    }
                    applyLoan.check1 = true;
                    

                }
                else
                {
                    red.Visible = true;
                    acInfo.ForeColor = Color.Red;
                    acInfo.Visible = true;
                    acInfo.Text = "Sorry, this account doesn't exist.....";
                    applyLoan.check1 = false;
                    green.Visible = false;
                    
                    
                }
                check2 = true;
            }
            else
            {
                acInfo.Visible = false;
                red.Visible = false;
                green.Visible = false;
                check2 = false;
            }
        }
        private string reqNo()
        {
                var random = new Random();
                string s = string.Empty;
                for (int i = 0; i < 5; i++)
                    s = String.Concat(s, random.Next(10).ToString());
                return s;

            
        }
        public string checkAc()
        {
            SqlConnection con = new SqlConnection(connection.connectionString);

            using (con)
            {
                string ac = reqNo();
                con.Open();
                string acc = "";
                SqlDataAdapter sda = new SqlDataAdapter("select *from LOANREQ where req_no=@req", con);
                sda.SelectCommand.Parameters.AddWithValue("@req", ac);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    while (dtbl.Rows.Count == 1)
                    {
                        dtbl.Clear();
                        acc = reqNo();
                        SqlDataAdapter sda1 = new SqlDataAdapter("select *from LOANREQ where req_no=@req", con);
                        sda1.SelectCommand.Parameters.AddWithValue("@acno", acc);
                        sda1.Fill(dtbl);
                    }
                    return acc;
                }
                else
                {
                    return ac;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("loans");
            loans l = new loans();
            l.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(l);
            menu.Instance.PnlContainer.Controls["loans"].BringToFront();
        }
    }
}
