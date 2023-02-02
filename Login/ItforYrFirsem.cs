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
    public partial class ItforYrFirsem : Form
    {
        Thread th;
        public ItforYrFirsem()
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
            Application.Run(new ItFourth());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open4113);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open4113(object obj)
        {
            Application.Run(new IT4113());
        }

        private void ItfirYrFirsem_Load(object sender, EventArgs e)
        {
            // no code
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open4123);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open4123(object obj)
        {
            Application.Run(new IT4123());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1134);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open1134(object obj)
        {
            Application.Run(new IT1134());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1144);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void open1144(object obj)
        {
            Application.Run(new IT1144());
        }
    }
}
