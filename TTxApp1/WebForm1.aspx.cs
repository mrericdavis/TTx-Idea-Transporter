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
    public partial class WebForm1 : System.Web.UI.Page
    {//Global variables to be used throughout this page
        int i = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                //Check to see if the cookie has been established
                if (Request.Cookies["UserCookie"] == null)
                {
                    //Do nothing
                }
                else
                {
                    //Redirect to the admin page
                   /* Response.Redirect("WebForm1.aspx");*/
                }
            }
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable CheckLogin = LoginDataClass_Collection.GetLoginInformation(txtUsername.Text, txtPassword.Text);
            //This is very simple.  Simply check the Rows' array to see if it has any data before trying to index into it.      
            //I used a simple logic block to determine if my object has data or not
            if (CheckLogin.Rows.Count > 0)
            {
                //Valid Data
                lblMessage.Text = "This is a valid username and password";
                int SecurityID = Convert.ToInt32(CheckLogin.Rows[i]["LoginID"].ToString());
                string UserName = CheckLogin.Rows[i]["Username"].ToString();
                //Then create the cookie for the very first time

                //Create the full cookie
                HttpCookie UserNameCookieID = new HttpCookie("UserCookie");
                //Add Value(s) to the Cookies
                UserNameCookieID["UserID"] = SecurityID.ToString();
                //Now add the Username also to the cookie for later use
                UserNameCookieID["UserName"] = UserName.ToString();
                //After adding the value - basically bound 
                Response.Cookies.Add(UserNameCookieID);
                //Now redirect the user to the admin page
                Response.Redirect("LandingPage.aspx");
            }
            else
            {
                //InValid Record
                lblMessage.Text = "The username and/or password you entered is invalid";
            }
        }

        }
    }