using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void studToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stud s1 = new Stud();
            s1.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book b1 = new Book();
            b1.Show();
        }
    }
}
