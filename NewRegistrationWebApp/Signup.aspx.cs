using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewRegistrationWebApp
{
    public partial class Signup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            if (TextFirstname.Text == "" || TextLastname.Text == "" || TextAddress.Text == "" || TextPassword.Text == "" || TextConfirmpassword.Text == "" || TextZip.Text == "")
            {
                Response.Write("<script> alert('Please enter all the fields'); </script>");

            }
            else
            {
                if (TextPassword.Text == TextConfirmpassword.Text)
                {
                    String[] checkBox_result = { }; String result="";

                    //code for checkbox
                    if (CheckBoxAreaofinterest1.Checked)
                    {
                        result = result + CheckBoxAreaofinterest1.Text.ToString() + ",";


                    } if (CheckBoxAreaofinterest2.Checked)
                    {
                        result = result + CheckBoxAreaofinterest2.Text.ToString() + ",";

                    }
                     if (CheckBoxAreaofinterest3.Checked)
                    {
                        result = result + CheckBoxAreaofinterest3.Text.ToString() + ",";
                    }
                     if (CheckBoxAreaofinterest4.Checked)
                    {
                        result = result + CheckBoxAreaofinterest4.Text.ToString() + ",";

                    }
                   

                    //code for file upload profile picture
                    string path;
                    if (FileUploadProfilepicture.HasFile)
                        FileUploadProfilepicture.SaveAs(HttpContext.Current.Request.PhysicalApplicationPath + "image/" + FileUploadProfilepicture.FileName);
                    path = FileUploadProfilepicture.FileName;
                    //end 
                    SqlCommand cmd = new SqlCommand("registration_Insert", con); //registration insert is stored procedure where we store data in table (table name=Registration)
                    con.Open(); //for opening database connection 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Firstname", TextFirstname.Text);
                    cmd.Parameters.AddWithValue("@Lastname", TextLastname.Text);
                    cmd.Parameters.AddWithValue("@Email", TextRegEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", TextAddress.Text);
                    cmd.Parameters.AddWithValue("@Gender", RadioButtonListGender.Text);
                    cmd.Parameters.AddWithValue("@Password", TextPassword.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", TextConfirmpassword.Text);
                    cmd.Parameters.AddWithValue("@Zip", TextZip.Text);
                    cmd.Parameters.AddWithValue("@State", DropDownListState.Text);
                    cmd.Parameters.AddWithValue("@Country", DropDownListCountry.Text);
                    cmd.Parameters.AddWithValue("@Areaofinterest", result.ToString());
                    cmd.Parameters.AddWithValue("@ProfilePicture", path);



                    int i = cmd.ExecuteNonQuery();//for execute store procedure query
                    con.Close();//for closing database connection 

                    if (i > 0)
                    {
                        popupDiv.Visible = true;
                       
                       // Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    Response.Write("<script> alert('Password not match! Please try again'); </script>");
                }
                
            }

        } 
        

          protected void btnLogin_Click(object sender, EventArgs e)
        {
                  Response.Redirect("Login.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }

        protected void done_ClickReg(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}