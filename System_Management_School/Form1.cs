using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Management_School
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-MJV39V9;Initial Catalog=Login;Integrated Security=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from log";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtUsername.Text.Equals(dr["username"].ToString()) && txtPassword.Text.Equals(dr["password"].ToString()))
                {
                    menuStrip1.Visible = true;
                    panel1.Visible = false;
                }
                else if (MessageBox.Show("Kujdes Emri Perdoruesit ose Password është gabim!\nDeshironi ta mbyllni aplikacionin", "Diqka shkoi gabim", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Exit();
                }
                
            }
            con.Close();

            //string username = textBox1.Text;
            //string password = textBox2.Text;

            //if (username == "student" && password == "student")
            //{
            /*    menuStrip1.Visible = true;
                panel1.Visible = false;*/
            //}
            //else
            //{
            //    MessageBox.Show("Invalid userid or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        

        private void newAdminissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndividualDetali sid = new StudentIndividualDetali();
            sid.Show();
        }

        private void addTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs ab = new AboutUs();
            ab.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("A jeni i sigurtë? Kjo do te fshije te dhenat tuaja te pa ruajtura", "Konfirmoni vazhdimin", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }

            
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Emri Perdoruesit"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Emri Perdoruesit"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }
    }
}
