﻿using System;
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
    public partial class UpgradeSemester : Form
    {
        public UpgradeSemester()
        {
            InitializeComponent();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Semester Update Warning !", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-MJV39V9; database = college; integrated security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewAdmission set semester = '" + comboBoxTo.Text + "' where semester='" + comboBoxFrom.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Ipgrade Successful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Upgrade Cancelled", "Cancle", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}
