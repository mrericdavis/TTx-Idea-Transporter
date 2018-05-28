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
    public partial class DetailedIdea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["UserCookie"] == null)
            {
                Response.Redirect("WebForm1.aspx");               
            }
            else
            {
                Title1.Text = Request.QueryString["Title"].ToString();
                Idea1.Text = Request.QueryString["Idea"].ToString();
                Employeetxt.Text = Request.QueryString["IID"].ToString();
            }
        }

        protected void EmptyStar1_Click(object sender, ImageClickEventArgs e)
        {
                string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString01);
            SqlCommand cmd = new SqlCommand("ustpUpdatePoints", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IID", SqlDbType.Int).Value = Convert.ToInt32(Employeetxt.Text);
            cmd.Parameters.Add("@Ptsvoting", SqlDbType.Int).Value = 1;
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)

            {
                throw ex;

            }
            finally

            {
                con.Close();
                con.Dispose();
                Response.Redirect("TrendingIdeaPage.aspx", true);
            }
        }

        protected void EmptyStar2_Click(object sender, ImageClickEventArgs e)
        {
            string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString01);
            SqlCommand cmd = new SqlCommand("ustpUpdatePoints", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IID", SqlDbType.Int).Value = Convert.ToInt32(Employeetxt.Text);
            cmd.Parameters.Add("@Ptsvoting", SqlDbType.Int).Value = 2;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)

            {
                throw ex;

            }
            finally

            {
                con.Close();
                con.Dispose();
                Response.Redirect("TrendingIdeaPage.aspx", true);
            }
        }

        protected void EmptyStar3_Click(object sender, ImageClickEventArgs e)
        {
            string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString01);
            SqlCommand cmd = new SqlCommand("ustpUpdatePoints", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IID", SqlDbType.Int).Value = Convert.ToInt32(Employeetxt.Text);
            cmd.Parameters.Add("@Ptsvoting", SqlDbType.Int).Value = 3;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)

            {
                throw ex;

            }
            finally

            {
                con.Close();
                con.Dispose();
                Response.Redirect("TrendingIdeaPage.aspx", true);
 
            }
        }

        protected void EmptyStar4_Click(object sender, ImageClickEventArgs e)
        {
            string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString01);
            SqlCommand cmd = new SqlCommand("ustpUpdatePoints", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IID", SqlDbType.Int).Value = Convert.ToInt32(Employeetxt.Text);
            cmd.Parameters.Add("@Ptsvoting", SqlDbType.Int).Value = 4;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)

            {
                throw ex;

            }
            finally

            {
                con.Close();
                con.Dispose();
                Response.Redirect("TrendingIdeaPage.aspx", true);
            }
        }

        protected void EmptyStar5_Click(object sender, ImageClickEventArgs e)
        {
            string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString01);
            SqlCommand cmd = new SqlCommand("ustpUpdatePoints", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IID", SqlDbType.Int).Value = Convert.ToInt32(Employeetxt.Text);
            cmd.Parameters.Add("@Ptsvoting", SqlDbType.Int).Value = 5;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)

            {
                throw ex;

            }
            finally

            {
                con.Close();
                con.Dispose();
                Response.Redirect("TrendingIdeaPage.aspx",true);
                
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