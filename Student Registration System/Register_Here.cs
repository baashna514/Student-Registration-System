using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyProject
{
    public partial class Register_Here : Form
    {
        String Gender;

        public Register_Here()
        {
            InitializeComponent();
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_FirstName.Clear();
            txt_LastName.Clear();
            txt_FatherName.Clear();
            dateTimePicker1.ResetText();
            txt_Cell.Clear();
            txt_Address.Clear();
            txt_City.Clear();
            txt_Country.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }
        

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\moina\Documents\Sign_Up_Form.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("insert into Register_Here (First_Name,Last_Name,Father_Name,Date_Of_Birth,Cell_No#,Gender,Address,City,Country) values('" + txt_FirstName.Text + "','" + txt_LastName.Text + "','" + txt_FatherName.Text + "','" + dateTimePicker1.Text +"','" + txt_Cell.Text + "','" + Gender + "','" + txt_Address.Text + "','" + txt_City.Text + "','" + txt_Country.Text+ "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Error..!! Try Again");
            }
        }

        
    }
}
