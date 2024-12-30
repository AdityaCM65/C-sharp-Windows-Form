using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        int time;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            lblres.Text = time.ToString();

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            time = 0;
            lblres.Text = time.ToString();
        }
    }
}
