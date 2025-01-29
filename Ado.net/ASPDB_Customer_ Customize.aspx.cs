using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Provider;

namespace Ado.net
{
    public partial class ASPDB_Customer__Customize : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=mayur;Database=ASPDB;Integrated Security = SSPI;");
            SqlCommand cmd = new SqlCommand("select * from customer",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }
    }
}