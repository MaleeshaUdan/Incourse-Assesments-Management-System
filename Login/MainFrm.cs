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
    public partial class MainFrm : Form
    {
        Thread th;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openAdmin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openAdmin(object obj)
        {
            Application.Run(new loginform());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openUser);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openUser(object obj)
        {
            Application.Run(new loginformUser());
        }
    }
}
