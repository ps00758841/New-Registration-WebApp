﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace NewRegistrationWebApp
{
    public partial class Login : System.Web.UI.Page
    {
      SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {

            if (TxtLoginUsername.Text == "" || TxtLoginPassword.Text == "")
            {
                Response.Write("<script> alert('please enter Email and password'); </script>");
            }
            else
            {



                string strcon = "Data Source=DESKTOP-SCJV9e2\\SQLEXPRESS02;Initial Catalog=DEMO;Integrated Security=True;";

                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand com = new SqlCommand("CheckUser", con);//checkuser is store procedure name
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("Email", TxtLoginUsername.Text);
                SqlParameter p2 = new SqlParameter("Password", TxtLoginPassword.Text);
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);

                SqlDataReader rd = com.ExecuteReader();

                if (rd.HasRows)
                {
                    Response.Write("<script> alert('Login Sucessfully'); </script>");
                    // rd.Read();
                    // Labelinfo.Text = "Login successful.";
                  Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Login Failed'); </script>");
                    // Labelinfo.Text = "Invalid username or password.";
                }


                con.Close();
            }
        }

        protected void Forget_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgetPassword.aspx");
          //  Response.Write("<script> alert('Password Reset Successfully') </script>");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
    }
}