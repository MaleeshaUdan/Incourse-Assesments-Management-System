using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Login
{
    public partial class AdminDetails : Form
    {
        Thread th;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ICA\Database\ICADB.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminDetails()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
                txtrepass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                txtrepass.UseSystemPasswordChar = true;
            }
        }

        private void btnCreAdmin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            string passRe = txtrepass.Text;

            if(user!="" && pass!="" && passRe != "")
            {
                if (pass == passRe)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Admin VALUES('" + user + "','" + pass + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    MessageBox.Show("Succesfully Created New Admin");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtrepass.Text = "";
                    checkBox1.Checked = false;

                }
                else
                {
                    MessageBox.Show("Password You Re-entered is Incorrect!");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtrepass.Text = "";
                    checkBox1.Checked = false;
                }

            }else
            {
                MessageBox.Show("All Fields Are Required!");
                txtuser.Text = "";
                txtpass.Text = "";
                txtrepass.Text = "";
                checkBox1.Checked = false;
            }
        }
        private void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Admin";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backform(object obj)
        {
            Application.Run(new Admin());
        }

        private void AdminDetails_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
            txtuser.Text = "";
            txtpass.Text = "";
            txtrepass.Text = "";
            checkBox1.Checked = false;
            display();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
            txtrepass.Text = "";
            checkBox1.Checked = false;
            display();
        }

        private void btnDelAdmin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;

            if (user!="" && pass!="")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ICA\Database\ICADB.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "SELECT * FROM Admin WHERE Username='" + user.Trim() + "'AND Password='" + pass.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb = new DataTable();
                sda.Fill(dtb);
                if (dtb.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Admin WHERE Username='" + user + "'"; ;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    MessageBox.Show("Succesfully Deleted");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtrepass.Text = "";
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password!");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtrepass.Text = "";
                    checkBox1.Checked = false;

                }
                }else
            {
                MessageBox.Show("Please Enter Admin Username And Password!");
            }

        }

        private void btnUpdPass_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            string repass = txtrepass.Text;

            if (user!="" && pass!="" && repass!="")
            {
                if (pass==repass)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Admin SET Password='" + pass + "'WHERE Username='" + user + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    display();
                    MessageBox.Show("Succesfully Updated");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtrepass.Text = "";
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("Password You Re - entered is Incorrect!");
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtrepass.Text = "";
                    checkBox1.Checked = false;
                }
            }else
            {
                MessageBox.Show("All Fields Are Required!");
                txtuser.Text = "";
                txtpass.Text = "";
                txtrepass.Text = "";
                checkBox1.Checked = false;
            }   
        }

        private void btnCheckRec_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) AS COUNT FROM Admin";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
