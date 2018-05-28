using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TTxApp1
{
    public partial class MyIdea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Check to see if the cookie has been established
                if (Request.Cookies["UserCookie"] == null)
                {
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    HttpCookie UserNameCookieID = Request.Cookies["UserCookie"];
                    string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString01);


                    SqlCommand cmd = new SqlCommand("ustpGetOnlyIdeas", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@LoginID", UserNameCookieID["UserID"]));
                    con.Open();
                    GridView1.EmptyDataText = "No Record Found";
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                }
            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LandingPage.aspx");
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = Request.Cookies["UserCookie"];
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
            Response.Redirect("WebForm1.aspx");
        }
    }
}