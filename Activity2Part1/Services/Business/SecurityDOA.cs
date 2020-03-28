using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Activity2Part1.Models;


namespace Activity2Part1.Services.Business
{
    public class SecurityDOA
    {
        public bool FindByUser(UserModel user)
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlDataReader rdr = null;

            string queryString = "SELECT * FROM dbo.Users WHERE USERNAME ='"
                + user.Name + "' AND PASSWORD ='" + user.Password + "'";

            bool loginSuccess = false;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
                if (rdr.HasRows) 
                { 
                    loginSuccess = true; 
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
            return loginSuccess;
        }
    }
}