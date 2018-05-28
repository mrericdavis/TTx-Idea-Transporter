using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public class LoginDataClass_Collection : System.Collections.ArrayList
{
    public class TMDataLayerDAL
    {
    }

    public static DataTable GetLoginInformation(string Username, string Password)
    {
        DataSet ds = new DataSet();
        string connectionString01 = ConfigurationManager.ConnectionStrings["GetPWDConnectionString"].ConnectionString;
        SqlConnection conn = null;

        try
        {
            //Open the connection
            conn = new SqlConnection(connectionString01);
            conn.Open();
            //Create the command with parameters
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ustpGetLoginCredentials";
            SqlParameter parm = cmd.Parameters.Add("@UserName", SqlDbType.VarChar);
            parm.Value = Username;
            //second parameter
            parm = cmd.Parameters.Add("@Password", SqlDbType.VarChar);
            parm.Value = Password;

            //Create the adapter
            SqlDataAdapter ad = new SqlDataAdapter(cmd);

            //Give the table a real name
            ad.TableMappings.Add("UserAccounts", "Logins");

            //Fill the dataset
            ad.Fill(ds);
        }
        catch (Exception ex)
        {
            //enter error message here
        }
        finally
        {
            //close the database connection
            conn.Close();
        }

        return ds.Tables[0];
    }
}
