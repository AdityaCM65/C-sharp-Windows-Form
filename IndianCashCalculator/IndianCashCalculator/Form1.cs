using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndianCashCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnres_Click(object sender, EventArgs e)
        {
            int ttnum, fhnum, thnum, hnum, ffnum, tnnnum, tnnum ,fnum, tnum, onum;

            ttnum = Convert.ToInt16(txt2000.Text);
            fhnum = Convert.ToInt16(txt500.Text);
            thnum = Convert.ToInt16(txt200.Text);
            hnum = Convert.ToInt16(txt100.Text);
            ffnum = Convert.ToInt16(txt50.Text);
            tnnnum = Convert.ToInt16(txt20.Text);
            tnnum = Convert.ToInt16(txt10.Text);
            fnum = Convert.ToInt16(txt5.Text);
            tnum = Convert.ToInt16(txt2.Text);
            onum = Convert.ToInt16(txt1.Text);

            int a, b,c, d, ej, f, g, h, i, j;

            a = (ttnum * 2000);
            b = (ttnum * 500);
            c = (ttnum * 200);
            d = (ttnum * 100);
            ej = (ttnum * 50);
            f = (ttnum * 20);
            g = (ttnum * 10);
            h = (ttnum * 5);
            i = (ttnum * 2);
            j = (ttnum * 1);
            
          
            lblres2000.Text = "= "+(a).ToString();
            lblres500.Text = "= " + (b).ToString();
            lblres200.Text = "= "+(c).ToString();
            lblres100.Text = "= "+(d).ToString();
            lblres50.Text = "= "+(ej).ToString();
            lblres20.Text = "= "+(f).ToString();
            lblres10.Text = "= "+(g).ToString();
            lblres5.Text = "= "+(h).ToString();
            lblres2.Text = "= "+(i).ToString();
            lblres1.Text = "= "+(j).ToString();

            int total;
            total = a + b + c + d + ej + f + g + h + i + j;

            lblrestotal.Text = "Total : "+total.ToString();


            

        }
    }
}
