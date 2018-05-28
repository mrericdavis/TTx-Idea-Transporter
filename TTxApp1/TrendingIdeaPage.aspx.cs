using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //this namespace is for sqlclient server  
using System.Configuration; // this namespace is add I am adding connection name in web config file config connection name  
using System.Data;

namespace TTxApp1
{
    public partial class TrendingIdeaPage : System.Web.UI.Page
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
                    string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString01);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ustpGetIdeas", con);
                    con.Close();
                }
            }

            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GridViewRow gr = GridView1.SelectedRow;
            Response.Redirect("DetailedIdea.aspx?Title=" + gr.Cells[1].Text + "&Idea=" + gr.Cells[3].Text + "&IID=" + gr.Cells[4].Text);
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