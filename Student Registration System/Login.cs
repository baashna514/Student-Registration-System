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
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {

        }
        

        private void btn_Login_Click(object sender, EventArgs e)
        {

            
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\moina\Documents\Sign_Up_Form.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

           // SqlCommand sc = new SqlCommand("Select * From Sign_Up where User_Name='" + txt_UserName.Text + "' and Password='" + txt_Password.Text+ "'",con);
            //con.Open();
            //sc.ExecuteNonQuery();
            //con.Close();


            

           SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\moina\Documents\Sign_Up_Form.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
           SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Sign_Up where User_Name='" + txt_UserName.Text + "' and Password='" + txt_Password.Text + "'", con);
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
            MessageBox.Show("Invalid UserName And Passsword..!!");
            }

          
        }
    } 
}
