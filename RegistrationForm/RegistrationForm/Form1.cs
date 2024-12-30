using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

            if (txtpassword.Text == txtcpassword.Text)
            {

                lblresname.Text = txtfname.Text + " " + txtmname.Text + " " + txtlname.Text;
                if (rdbmale.Checked == true)
                {
                    lblresgender.Text = rdbmale.Text;
                }
                else
                {
                    lblresgender.Text = rdbfemale.Text;
                }

                lblresmobile.Text = txtmobile.Text;
                lblresemail.Text = txtemail.Text;
                lblrespass.Text = txtpassword.Text;
                lblrescpass.Text = txtcpassword.Text;
            }
            else
            {
                lblrespasscheck.Text = "Password And Confirm Password Must be Same";
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
