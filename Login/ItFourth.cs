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
    public partial class ItFourth : Form
    {
        Thread th;
        public ItFourth()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItYrSel ysel = new ItYrSel();
            this.Close();
            th = new Thread(openback);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openback(object obj)
        {
            Application.Run(new ItYrSel());
        }
        private void openfirsem(object obj)
        {
            Application.Run(new ItforYrFirsem());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ItfirYrFirsem ysel = new ItfirYrFirsem();
            this.Close();
            th = new Thread(openfirsem);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opensecsem);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opensecsem(object obj)
        {
            Application.Run(new ItforYrSecsem());
        }
    }
}
