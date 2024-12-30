using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumGuessing
{
    public partial class Form1 : Form
    {
        int sysNum;
        Random rnd = new Random();
        int count = 1;
       
        public Form1()
        {
            InitializeComponent();
             sysNum = rnd.Next(1, 10);
        }

        private void btnguess_Click(object sender, EventArgs e)
        {
            int unum;
            unum = Convert.ToInt32(txtnum.Text);
           

            if(unum == sysNum)
            {
                lblres.Text = "WON";

                lbltime.ForeColor = Color.Green;
                lbltime.Text = "You Guessed In " + count + " Attempts";

            }
           
            
            else if(unum < sysNum)
            {
                lbltime.ForeColor = Color.Red;
                lbltime.Text = "Enter Higher Number !!!";

                count++;

            }

            else if (unum > sysNum)
            {
                lbltime.ForeColor = Color.Red;
                lbltime.Text = "Enter Lower Number !!!";

                count++;

            }
            else
            {
                lblres.Text = "LOSS";
            }
        }
    }
}
