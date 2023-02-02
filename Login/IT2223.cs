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
    /*----Here coding contains
      
        insert
        delete
        update
        search
        Total number of records
        clear
        home   
         ------------------------*/
    public partial class IT2223 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ICA\Database\ICADB.mdf;Integrated Security=True;Connect Timeout=30");
        Thread th;
        public IT2223()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backform(object obj)
        {
            Application.Run(new ItsecYrSecsem());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //no code here
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string index = txtInd.Text;
            string reg = txtReg.Text;
            
           


            if (index!="" && reg !="" && numericText1.Text!="" && numericText2.Text!="" && numericText3.Text!="")
            {
                int ic1 = Convert.ToInt32(numericText1.Text);
                int ic2 = Convert.ToInt32(numericText2.Text);
                int ic3 = Convert.ToInt32(numericText3.Text);

                if (ic1 >= 0 && ic1 <= 100 && ic2 >= 0 && ic2 <= 100 && ic3 >= 0 && ic3 <= 100)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO IT2223 VALUES('" + index + "','" + reg + "','" + ic1 + "','" + ic2 + "','" + ic3 + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    insertDisplay();
                    MessageBox.Show("Sucessfully inserted");
                    txtInd.Text = "";
                    txtReg.Text = "";
                    numericText1.Text = "";
                    numericText2.Text = "";
                    numericText3.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
                else
                {
                    MessageBox.Show("Invalid Marks!");
                    txtInd.Text = "";
                    txtReg.Text = "";
                    numericText1.Text = "";
                    numericText2.Text = "";
                    numericText3.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("All Fields Are Required!");
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtInd.Text = "";
            txtReg.Text = "";
            numericText1.Text = "";
            numericText2.Text = "";
            numericText3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void insertDisplay()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM IT2223";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string index = txtInd.Text;
            string reg = txtReg.Text;

            if (index != "" || reg != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM IT2223 WHERE INDEXNUMBER='" + index+"' OR REGNUMBER='"+reg+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                insertDisplay();
                MessageBox.Show("Sucessfully deleted");
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

            }
            else
            {
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                MessageBox.Show("Index or Registrtion field is required!");

            }
        }

        private void IT1113_Load(object sender, EventArgs e)
        {
            insertDisplay();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {

            txtInd.Text = "";
            txtReg.Text = "";
            numericText1.Text = "";
            numericText2.Text = "";
            numericText3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            userCounttDisplay();
        }
        private void userCounttDisplay()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT (*) AS STUDENTS FROM IT2223";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string index = txtInd.Text;
            string reg = txtReg.Text;

            if (index!="" || reg!="")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM IT2223 WHERE INDEXNUMBER='" + index + "' OR REGNUMBER='" + reg + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

            }
            else
            {
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                MessageBox.Show("Please Enter Index Number of Registration Number!");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            txtInd.Text = "";
            txtReg.Text = "";
            numericText1.Text = "";
            numericText2.Text = "";
            numericText3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            insertDisplay();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string index = txtInd.Text;
            string reg = txtReg.Text;
            
            if (index!="" || reg != "")
            {
                if(numericText1.Text!="" || numericText2.Text!="" || numericText3.Text != "")
                {
                    if (numericText1.Text!="")
                    {
                        int ica1 = Convert.ToInt32(numericText1.Text);

                        if (ica1 >= 0 && ica1 <= 100)
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE IT2223 SET ICA1='" + ica1 + "'WHERE INDEXNUMBER='" + index + "'OR REGNUMBER='" + reg + "'";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            txtInd.Text = "";
                            txtReg.Text = "";
                            numericText1.Text = "";
                            numericText2.Text = "";
                            numericText3.Text = "";
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                            radioButton3.Checked = false;
                            MessageBox.Show("Invalid Marks!");
                        }
                    }
                    if (numericText2.Text != "")
                    {
                        int ica2 = Convert.ToInt32(numericText2.Text);
                        if (ica2 >= 0 && ica2 <= 100)
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE IT2223 SET ICA2='" + ica2 + "'WHERE INDEXNUMBER='" + index + "'OR REGNUMBER='" + reg + "'";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }else
                        {
                            txtInd.Text = "";
                            txtReg.Text = "";
                            numericText1.Text = "";
                            numericText2.Text = "";
                            numericText3.Text = "";
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                            radioButton3.Checked = false;
                            MessageBox.Show("Invalid Marks!");
                        }
                    }
                    if (numericText3.Text != "")
                    {
                        int ica3 = Convert.ToInt32(numericText3.Text);

                        if (ica3 >= 0 && ica3 <= 100)
                        {
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE IT2223 SET ICA3='" + ica3 + "'WHERE INDEXNUMBER='" + index + "'OR REGNUMBER='" + reg + "'";
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            txtInd.Text = "";
                            txtReg.Text = "";
                            numericText1.Text = "";
                            numericText2.Text = "";
                            numericText3.Text = "";
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                            radioButton3.Checked = false;
                            MessageBox.Show("Invalid Marks!");
                        }
                    }
                    insertDisplay();
                    txtInd.Text = "";
                    txtReg.Text = "";
                    numericText1.Text = "";
                    numericText2.Text = "";
                    numericText3.Text = "";
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    MessageBox.Show("Updated Sucessfully");
                    
                }
                else
                {
                    MessageBox.Show("Please Enter ICA MArks!");
                }
            }
            else
            {
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                MessageBox.Show("Please Enter Index Number or Registration Number!");
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MAX(ICA1) AS MAXIMUM FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MAX(ICA2) AS MAXIMUM FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MAX(ICA3) AS MAXIMUM FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton3.Checked = false;
            }
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MIN(ICA1) AS LOWEST FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton2.Checked = false;
            }
            if (radioButton2.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MIN(ICA2) AS LOWEST FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MIN(ICA3) AS LOWEST FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton2.Checked = false;
            }
        }

        private void btnAve_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT AVG(ICA1) AS AVERAGE FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT avg(ICA2) AS AVERAGE FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT AVG(ICA3) AS AVERAGE FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton3.Checked = false;
            }
        }

        private void btnTot_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SUM(ICA1) AS TOTAL FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SUM(ICA2) AS TOTAL FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT SUM(ICA3) AS TOTAL FROM IT2223";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                txtInd.Text = "";
                txtReg.Text = "";
                numericText1.Text = "";
                numericText2.Text = "";
                numericText3.Text = "";
                radioButton3.Checked = false;
            }
        }
    }
}
