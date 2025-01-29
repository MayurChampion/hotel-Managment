using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm2
{
    public partial class Response : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.Form["txtName"];
            string Phone = Request.Form["txtPhone"];
            string Email = Request.Form["txtEmail"];
            Response.Write("name : " + Name + "<br/>");
            Response.Write("Phone : " + Phone +"<br/>");
            Response.Write("Email : " + Email+"<br/>");
        }
    }
}