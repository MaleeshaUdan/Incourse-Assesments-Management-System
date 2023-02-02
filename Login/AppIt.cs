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
    public partial class AppIt : Form
    {
        Thread th;
        public AppIt()
        {
            InitializeComponent();
        }

        private void AppIt_Load(object sender, EventArgs e)
        {
           //no code yet
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //loginfrm lg = new loginfrm();

            this.Close();
            th = new Thread(openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openform(object obj)
        {
            Application.Run(new MainFrm());
        }
        private void openformselyr(object obj)
        {
            Application.Run(new ItYrSel());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItYrSel isel = new ItYrSel();

            this.Close();
            th = new Thread(openformselyr);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
