using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewRegistrationWebApp
{
    public partial class Grid_View_Demo : System.Web.UI.Page
    {
        DataSet dt;
        DataTable ds;
        string strcon = "Data Source=DESKTOP-SCJV9e2\\SQLEXPRESS02;Initial Catalog=DEMO;Integrated Security=True;";
        protected void Page_Load(object sender, EventArgs e)
        { 
            string selectSQL = "SELECT * from RegisterForm";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt = new DataSet();
            adapter.Fill( dt,"RegisterForm");
            //ViewState["dt"] = dt;
            GridView1.DataSource = dt as DataSet;
           // GridView1.DataSource = dt;
           Console.WriteLine("GriDview Data"+GridView1.ToString() + "DT --  >" +dt  );
            GridView1.DataBind();
          
        }
        protected void BindGrid()
        {
            // GridView1.DataSource = ViewState["dt"] as DataSet;
            GridView1.DataSource = dt as DataSet;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "comdel")
            {

                int l = Convert.ToInt32(e.CommandArgument);
                SqlCommand cmd = new SqlCommand(strcon);
                SqlConnection con = new SqlConnection(strcon);
               
                con.Open();
                cmd.Parameters.AddWithValue("@a", l);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    Response.Write("Record deleted");
                    BindGrid();
                }
                else
                {
                    Response.Write("Recodrd not deleted...");
                }

                Page_Load(sender, e);
            }
        }

            protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string item = e.Row.Cells[0].Text;
                foreach (Button button in e.Row.Cells[2].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Delete")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                    }
                }
            }
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            DataTable dt = ViewState["dt"] as DataTable;
            GridView1.DataSource = dt;
            dt.Rows[index].Delete();
            ViewState["dt"] = dt;
            BindGrid();
        }

    }

}