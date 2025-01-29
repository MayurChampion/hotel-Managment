using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ado.net
{
    public partial class Login_successful : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            grv.DataSource = Cache["user"];
            grv.DataBind();
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            

            Response.Redirect("Hotel_registrations.aspx");
        }
    }
}