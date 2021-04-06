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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool isChecked = radioMale.Checked;

            if (isChecked)
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-MJV39V9; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,yer,adr) values ('"+txtFName.Text+"','"+gender+"','"+dateTimePickerDOB.Text+"','"+txtMobile.Text+"','"+txtEmail.Text+"','"+txtSemester.Text+"','"+TxtProgramming.Text+"','"+txtDuration.Text+"','"+txtAddress.Text+"')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
