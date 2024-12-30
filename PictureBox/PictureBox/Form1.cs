using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        int c;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnpreious_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            c++;
            pictureBox1.Image = imageList1.Images[c];

        }

        private void btnpreious_Click_1(object sender, EventArgs e)
        {
            c--;
            pictureBox1.Image = imageList1.Images[c];

        }
    }
}
