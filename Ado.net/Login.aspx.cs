using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Ado.net
{
    public partial class RegistrationSuccess : System.Web.UI.Page
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                txtuser.Focus();
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=mayur;Database=hotel_management;Integrated Security = SSPI");
        
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from users where username = @username AND passwords = @passwords";
            con.Open();
            cmd.Parameters.AddWithValue("@username", txtuser.Text);
            cmd.Parameters.AddWithValue("@passwords", txtpassw.Text);
            SqlDataReader dr = cmd.ExecuteReader();
         
            Cache["user"]= dr;
            if (dr.HasRows)
            {
                
                Response.Redirect("Login_Successful.aspx");
            }
            else
            {

                lbl.Text = "invalid username or password.";
            }
            con.Close();
        }
    }
}