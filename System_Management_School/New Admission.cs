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
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string faname = txtFatherName.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            string dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string email = txtEmail.Text;
            string semester = txtSemester.Text;
            string program = txtProgramming.Text;
            string sname = txtSchoolName.Text;
            string duration = txtDuration.Text;
            string add = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-MJV39V9; database =college; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission (fname,faname,gender,dob,mobile,email,semester,prog,sname,duration,addres) values ('" + name + "','" + faname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + add + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Eshte Regjistruar me sukses.", "Regjisrimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtFatherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-MJV39V9; database =college; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(NAID) from NewAdmission";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc;
            abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = (abc + 1).ToString();

           
        }
    }
}
