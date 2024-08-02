using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace banking2
{

    public partial class customer : UserControl
    {
        Boolean a = false;
        
        public customer()
        {
            InitializeComponent();

        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {
            name.Clear();
            warn.Visible = false;
        }

        private void fName_Click(object sender, EventArgs e)
        {
            fName.Clear();
            warn.Visible = false;
        }

        private void phn_Click(object sender, EventArgs e)
        {
            phn.Clear();
            warn.Visible = false;
        }

        private void adrs1_Click(object sender, EventArgs e)
        {
            adrs1.Clear();
            warn.Visible = false;
        }

        private void adrs2_Click(object sender, EventArgs e)
        {
            adrs2.Clear();
            warn.Visible = false;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            adrs3.Clear();
            warn.Visible = false;
        }

        private void adrs4_Click(object sender, EventArgs e)
        {
            adrs4.Clear();
            warn.Visible = false;
        }

        private void mail_Click(object sender, EventArgs e)
        {
            mail.Clear();
            warn.Visible = false;
        }

        private void adrsid_Click(object sender, EventArgs e)
        {
            adrsid.Clear();
            warn.Visible = false;
        }

        private void id_Click(object sender, EventArgs e)
        {
            id.Clear();
            warn.Visible = false;
        }

        private void amt_Click(object sender, EventArgs e)
        {
            amt.Clear();
            warn.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            connection c = new connection();
            string accNo = c.checkAc();
            connection.accno = accNo;
            string user = connection.user;
            string adrs = adrs1.Text + "," + adrs2.Text + "," + adrs3.Text + "," + adrs4.Text;
            try
            {
                using (con)
                {
                    con.Open();
                    if (a)
                    {
                        warn.Visible = true;
                        warn.Text = "Warning: Please fill all the details.....";
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into CUSTOMER values(@acno,@name,@gender,@dob,@fname,@addrs,@phone,@mail,@aproof,@aid,@iproof,@id,@e_user,@doc,@sbal,@sal)", con);
                        SqlCommand cmd2 = new SqlCommand("insert into BALANCE values(@accno,@n,@bal)",con);
                        cmd.Parameters.AddWithValue("@acno", accNo);
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@gender", gender.Text);
                        cmd.Parameters.AddWithValue("@dob", date.Text);
                        cmd.Parameters.AddWithValue("@fname", fName.Text);
                        cmd.Parameters.AddWithValue("@addrs", adrs);
                        cmd.Parameters.AddWithValue("@mail", mail.Text);
                        cmd.Parameters.AddWithValue("@phone", phn.Text);
                        cmd.Parameters.AddWithValue("@aproof", aProof.Text);
                        cmd.Parameters.AddWithValue("@aid", adrsid.Text);
                        cmd.Parameters.AddWithValue("@iproof", iProof.Text);
                        cmd.Parameters.AddWithValue("@id", id.Text);
                        cmd.Parameters.AddWithValue("@e_user", user);
                        cmd.Parameters.AddWithValue("@doc", doc.Text);
                        cmd.Parameters.AddWithValue("@sbal", amt.Text);
                        cmd.Parameters.AddWithValue("@sal",sal.Text);
                        cmd2.Parameters.AddWithValue("@accno",accNo);
                        cmd2.Parameters.AddWithValue("@n",name.Text);
                        cmd2.Parameters.AddWithValue("@bal",amt.Text);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        if(!menu.Instance.PnlContainer.Controls.ContainsKey("acc"))
                        {
                            acc a = new acc();
                            a.Dock = DockStyle.Fill;
                            menu.Instance.PnlContainer.Controls.Add(a);
                            
                        }
                        menu.Instance.PnlContainer.Controls["acc"].BringToFront();
                        menu.Instance.lbl.Visible = false;


                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
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

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
