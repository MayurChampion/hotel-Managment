using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Ado.net
{
    public class chack_username
    {
        SqlCommand cmd;
        SqlConnection con;
        public chack_username()
        {
            con = new SqlConnection(ReadCS.ASPDB);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
        }
         public void Select_users(string  Username,string Password)
        {
            con.Open();
            cmd.CommandText = "uses_Select";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Username",Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            con.Close();
        }
    }
}