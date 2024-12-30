using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistrationFormDB
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=studentinfo;Integrated Security=True;Pooling=False";
            display();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into stud values(@ln , @fn , @mn , @rno , @eml , @add , @mob , @gen)",con);
            cmd.Parameters.AddWithValue("@ln",txtlname.Text);
            cmd.Parameters.AddWithValue("@fn", txtfname.Text);
            cmd.Parameters.AddWithValue("@mn", txtmname.Text);
            cmd.Parameters.AddWithValue("@rno", Convert.ToInt32(txtroll.Text));
            cmd.Parameters.AddWithValue("@eml", txtemail.Text);
            cmd.Parameters.AddWithValue("@add", txtadd.Text);
            cmd.Parameters.AddWithValue("@mob", txtmob.Text);

            if (rdbmale.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gen",rdbmale.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@gen", rdbfemale.Text);
            }

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");

            con.Close();
            display();
            

        }

        void display()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from stud", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            reset();

        }

        void reset()
        {
            txtlname.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            txtroll.Text = "";
            txtemail.Text = "";
            txtadd.Text = "";
            txtmob.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtroll.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtmob.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update stud set lname=@ln ,fname=@fn ,mname=@mn,email=@eml , address=@add ,mobno=@mob where rollno=@rno", con);
            cmd.Parameters.AddWithValue("@ln", txtlname.Text);
            cmd.Parameters.AddWithValue("@fn", txtfname.Text);
            cmd.Parameters.AddWithValue("@mn", txtmname.Text);
            cmd.Parameters.AddWithValue("@rno", Convert.ToInt32(txtroll.Text));
            cmd.Parameters.AddWithValue("@eml", txtemail.Text);
            cmd.Parameters.AddWithValue("@add", txtadd.Text);
            cmd.Parameters.AddWithValue("@mob", txtmob.Text);

            if (rdbmale.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gen", rdbmale.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@gen", rdbfemale.Text);
            }

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");

            con.Close();
            display();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("delete from stud where rollno = @rno", con);
         
            cmd.Parameters.AddWithValue("@rno", Convert.ToInt32(txtroll.Text));
          
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");

            con.Close();
            display();
        }
    }
}
