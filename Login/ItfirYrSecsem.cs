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
    public partial class ItfirYrSecsem : Form
    {
        Thread th;
        public ItfirYrSecsem()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(backform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void backform(object obj)
        {
            Application.Run(new ItFir());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1214);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open1214(object obj)
        {
            Application.Run(new IT1214());
        }

        private void ItfirYrFirsem_Load(object sender, EventArgs e)
        {
            // no code
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1223);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open1223(object obj)
        {
            Application.Run(new IT1223());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1232);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open1232(object obj)
        {
            Application.Run(new IT1232());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1242);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open1242(object obj)
        {
            Application.Run(new IT1242());
        }
    }
}
