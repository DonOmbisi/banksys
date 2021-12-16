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
using System.Configuration;

namespace banking2
{
    /* 
     * Flow is we want on every button click this form should go back  
     * According to the operation another form should take its place. 
     * This form denotes Account Operation 
    */
    public partial class AccountOp : UserControl
    {
        public static string accOpc_name;
        public AccountOp()
        {
            InitializeComponent();
        }

        
        /*
         * On button click we want the deposit form to come upon 
         * The present form in display, 
         * Here deposit form comes upon the present form 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("deposit");
            deposit d = new deposit();
            d.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(d);
            menu.Instance.PnlContainer.Controls["deposit"].BringToFront();
        }

        private void AccountOp_Load(object sender, EventArgs e)
        {
           this.myLogic();
        }

        /*
         * On button click we want the withdrawal form to come upon 
         * The present form in display, 
         * Here withdrawal form comes upon the present form 
         */
        private void button2_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("withdrawal");
            withdrawal w = new withdrawal();
            w.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(w);
            menu.Instance.PnlContainer.Controls["withdrawal"].BringToFront();
        }

        private void addrs_Click(object sender, EventArgs e)
        {

        }

        /* 
         * Hope you don't mind the function names  
         * We are reading the data from data base and displaying it on the form
        */
        public  void myLogic()
        {
            SqlConnection con = new SqlConnection(connection.connectionString);
            string accNo = connection.acc_acOp;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ac_no,c_name,c_address,c_email,c_phone,c_gender from CUSTOMER where ac_no=@account", con);
            cmd.Parameters.AddWithValue("@account", accNo);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                acc.Text = da.GetValue(0).ToString();
                name.Text = da.GetValue(1).ToString();
                AccountOp.accOpc_name = name.Text;
                addrs.Text = da.GetValue(2).ToString();
                mail.Text = da.GetValue(3).ToString();
                phn.Text = da.GetValue(4).ToString();
                gender.Text = da.GetValue(5).ToString();
            }
            da.Close();
            try
            {
               // Needed only the catch statement
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        /*
         * On button click we want the passbook form to come upon 
         * The present form in display, 
         * Here passbook form comes upon the present form 
         */
        private void button6_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("passbook");
            
                passbook p = new passbook();
                p.Dock = DockStyle.Fill;
                menu.Instance.PnlContainer.Controls.Add(p);
                menu.Instance.PnlContainer.Controls["passbook"].BringToFront();
        }

        /*
         * On button click we want the updateInfo form to come upon 
         * The present form in display, 
         * Here updateInfo form comes upon the present form 
         */
        private void button4_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("updateInfo");

            updateInfo u = new updateInfo();
            u.Dock = DockStyle.Fill;
            menu.Instance.PnlContainer.Controls.Add(u);

            menu.Instance.PnlContainer.Controls["updateInfo"].BringToFront();
        }

        /*
         * On button click we want the transfer form to come upon 
         * The present form in display, 
         * Here transfer form comes upon the present form 
         */
        private void button3_Click(object sender, EventArgs e)
        {
            menu.Instance.PnlContainer.Controls.RemoveByKey("transfer");
            
                transfer t = new transfer();
                t.Dock = DockStyle.Fill;
                menu.Instance.PnlContainer.Controls.Add(t);
            
            menu.Instance.PnlContainer.Controls["transfer"].BringToFront();
        }

        private void acc_Click(object sender, EventArgs e)
        {

        }
    }
}
