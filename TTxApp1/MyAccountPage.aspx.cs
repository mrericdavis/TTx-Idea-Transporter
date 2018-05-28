using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TTxApp1
{
    public partial class MyAccountPage : System.Web.UI.Page
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

        protected void BtnMyIdea_Click(object sender, EventArgs e)
        {
            HttpCookie UserNameCookieID = Request.Cookies["UserCookie"];
            Response.Redirect("MyIdea.aspx", true);
            Response.End();
        }

        protected void BtnMyPoints_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyPoints.aspx", true);
            Response.End();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("LandingPage.aspx");
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
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