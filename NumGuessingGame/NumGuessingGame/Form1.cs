using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumGuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            int num ,  rnum , count = 0;
            num = Convert.ToInt32(txtnum.Text);
            Random rnd = new Random();
            rnum = rnd.Next(1, 10);
            lblres.Text = num.ToString();
            label1.Text = rnd.ToString();
            if(num == rnum )
            {
                lblres.Text = "You Guessed It ";
                
            }
            else
            {
                count++;
            }
        }
    }
}
