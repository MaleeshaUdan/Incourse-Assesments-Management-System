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

namespace Login
{
    public partial class Admin : Form
    {
        Thread th;
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backform(object obj)
        {
            Application.Run(new MainFrm());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(loadAdmin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void loadAdmin(object obj)
        {
            Application.Run(new AdminDetails());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(loadUser);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void loadUser(object obj)
        {
            Application.Run(new UserDetails());
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // no codes here
        }
    }
}
