using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Login
{
    public partial class loginform : Form
    {
        Thread th;
        public loginform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            /*This is just a lebel and no code is written here*/
        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {
            usertxt.Text = "";
            usertxt.Text = "";
            usertxt.Focus(); //when loading focusing to username field
                
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string user = usertxt.Text;
            string pass = passtxt.Text;

            if(user!="" && pass != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ICA\Database\ICADB.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "SELECT * FROM Admin WHERE Username='" + user.Trim() + "'AND Password='" + pass.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count == 1)
                {
                    this.Close();
                    th = new Thread(openform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password!");
                    usertxt.Text = "";
                    passtxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Required!");
                usertxt.Text = "";
                passtxt.Text = "";
            }
            
        }
        private void openform(object obj)
        {
            Application.Run(new Admin());
        }
        private void backform(object obj)
        {
            Application.Run(new MainFrm());
        }
           
        private void btnclr_Click(object sender, EventArgs e)
        {
            usertxt.Text = "";
            passtxt.Text = "";
            usertxt.Focus();
        }
    }
}
