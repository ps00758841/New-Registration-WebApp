using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Drawing;

namespace NewRegistrationWebApp
{
    public partial class Dashboard : System.Web.UI.Page
    {
        string strcon = "Data Source=DESKTOP-SCJV9e2\\SQLEXPRESS02;Initial Catalog=DEMO;Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
               refreshdata();
            }
        }
        public void refreshdata()
        {

           
          // SqlCommand cmd = new SqlCommand(strcon);
           String query = "Select * from RegisterForm";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd1);
           DataTable dt = new DataTable();
          sda.Fill(dt);
           grvEmployee.DataSource = dt;
            grvEmployee.DataBind();

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {
           
        }

        //protected void Unnamed2_Click(object sender, EventArgs e)
        //{
        //    string strcon = "Data Source=DESKTOP-SCJV9e2\\SQLEXPRESS02;Initial Catalog=DEMO;Integrated Security=True;";

        //    SqlConnection con = new SqlConnection(strcon);
        //    con.Open();
        //    SqlCommand com = new SqlCommand("CheckEmail", con);//  CheckEmail is stored procedure
        //    com.CommandType = CommandType.StoredProcedure;
        //    SqlParameter paramId = new SqlParameter();
        //    paramId.ParameterName = "@Email";
        //    paramId.Value = "";
        //    com.Parameters.Add(paramId);
        //    //con.Open();

        //    int i = com.ExecuteNonQuery();

        //    con.Close();

        //    if (i > 0)
        //    {
        //        Response.Write("<script> alert('delete Sucessfully'); </script>");
        //        Response.Redirect("Dashboard.aspx");
        //    }
        //    else
        //    {
        //        Response.Write("<script> alert('No Email Exits to delete'); </script>");
        //        Response.Write("<script> alert('delete failed'); </script>");
        //    }
        //}

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void Forget_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteClick(object sender, EventArgs e)
        {
            if (TxtLoginUsername_deleteRequest.Text.ToString()=="" || TxtLoginUsername_deleteRequest.Text.Length <=0)
            {
                Response.Write("<script> alert('PLease provide email for delete request.'); </script>");
            }
            else{

                string strcon = "Data Source=DESKTOP-SCJV9e2\\SQLEXPRESS02;Initial Catalog=DEMO;Integrated Security=True;";

                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                SqlCommand com = new SqlCommand("CheckEmail", con);//  CheckEmail is stored procedure
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@Email";
                paramId.Value = TxtLoginUsername_deleteRequest.Text;
                com.Parameters.Add(paramId);
                //con.Open();

                int i = com.ExecuteNonQuery();

                con.Close();
                refreshdata();
                if (i > 0)
                {
                    //  alert_meth();
                    //    Response.Write("<script> alert('delete Sucessfully'); </script>");
                    // DeleteRequestLabel.Text =   TxtLoginUsername_deleteRequest+ " record is Deleted";
                    Response.Write("<script> alert('delete successful!'); </script>");
                }
                else
                {
                    Response.Write("<script> alert('delete failed.. Email is not found'); </script>");
                }


            }

        }

        protected void LogoutClick(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");



        }
    }
}


        
    
