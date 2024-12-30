using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtimepicker_ValueChanged(object sender, EventArgs e)
        {
            int day , year , month;
            day = DateTime.Now.Subtract(dtimepicker.Value).Days;
            year = day / 365;
            txtyear.Text = year.ToString();
            month = day / 30;
            txtmonth.Text = month.ToString();
            
            txtdays.Text = day.ToString();
        }
    }
}
