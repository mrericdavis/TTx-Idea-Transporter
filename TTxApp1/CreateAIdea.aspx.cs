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
    public partial class CreateAIdea : System.Web.UI.Page

    { protected void Page_Load(object sender, EventArgs e)
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
                    Employeetxt.Visible = false;
                    HttpCookie UserNameCookieID = Request.Cookies["UserCookie"];
                    Employeetxt.Text = UserNameCookieID["UserID"];
                }
            }

        }

        protected void btnIdea_Click(object sender, EventArgs e)
        {

        string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString01);
        SqlCommand cmd = new SqlCommand("ustpInsertIdeas",con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add("@Title", SqlDbType.VarChar, 100).Value = Titletxt.Text.ToString();
        cmd.Parameters.Add("@Idea", SqlDbType.VarChar, 2000).Value = Ideatxt.Text.ToString();
        cmd.Parameters.Add("@LoginID", SqlDbType.Int).Value = (int.Parse(Employeetxt.Text));

            try
        {
            con.Open();
            cmd.ExecuteNonQuery();

        } catch (Exception ex)

        {
                throw ex;

        } finally

        {
            con.Close();
            con.Dispose();
            //Response.Redirect("TrendingIdeaPage.aspx");
            Response.Write("<script language='javascript'>window.alert('TTx Thanks You For Your Suggestions!!! You Are The Best');window.location='TrendingIdeaPage.aspx';</script>");
                
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