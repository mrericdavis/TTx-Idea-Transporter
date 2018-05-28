using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTxApp1
{
    public partial class LandingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserCookie"] == null)
            {
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
 
            }
        }

        protected void BtnMyAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyAccountPage.aspx", true);
            Response.End();
        }

        protected void BtnTrendingIdeas_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrendingIdeaPage.aspx", true);
            Response.End();
        }

        protected void BtnMakeNewIdea_Click(object sender, EventArgs e)
        {
            HttpCookie UserNameCookieID = Request.Cookies["UserCookie"];
            
            Response.Redirect("CreateAIdea.aspx", true);
            Response.End();
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