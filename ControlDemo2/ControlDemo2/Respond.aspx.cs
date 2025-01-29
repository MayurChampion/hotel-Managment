using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class Respond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // this is post request
            //string Name = Request.Form["txtName"];
            //string Phone = Request.Form["txtPhone"];
            //string Email = Request.Form["txtEmail"];
            //Response.Write("<h3>Hello " + Name + ", we have received your contact details.</h3>");
            //Response.Write("Contact Phone: " + Phone + "<br />");
            //Response.Write("Contact Email: " + Email + "<br />");

            // this is get request
            //string Name = Request.QueryString["txtName"];
            //string Phone = Request.QueryString["txtPhone"];
            //string Email = Request.QueryString["txtEmail"];
            //Response.Write("<h3>Hello " + Name + ", we have received your contact details.</h3>");
            //Response.Write("Contact Phone: " + Phone + "<br />");
            //Response.Write("Contact Email: " + Email + "<br />");

            string Name = Request["txtName"];
            string Phone = Request["txtPhone"];
            string Email = Request["txtEmail"];
            Response.Write("<h3>Hello " + Name + ", we have received your contact details.</h3>");
            Response.Write("Contact Phone: " + Phone + "<br />");
            Response.Write("Contact Email: " + Email + "<br />");


        }
    }
}