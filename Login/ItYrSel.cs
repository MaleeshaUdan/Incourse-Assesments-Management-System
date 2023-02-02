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
    public partial class ItYrSel : Form
    {
        Thread th;
        public ItYrSel()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AppIt ai = new AppIt();

            this.Close();
            th = new Thread(openback);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openback(object obj)
        {
            Application.Run(new AppIt());
        }
        private void open1yr(object obj)
        {
            Application.Run(new ItFir());
        }

        private void btnit1yr_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(open1yr);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnit2yr_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open2yr);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open2yr(object obj)
        {
            Application.Run(new ItSec());
        }

        private void btnit3yr_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open3yr);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open3yr(object obj)
        {
            Application.Run(new ItThird());
        }

        private void btnit4yr_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open4yr);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open4yr(object obj)
        {
            Application.Run(new ItFourth());
        }
    }
}
