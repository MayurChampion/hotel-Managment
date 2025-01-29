using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
             txt1.Focus();
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "admin" && txt2.Text == "admin@123"  )
            {
                Server.Transfer("SuccessPage.aspx");  //we can transfer control from 1 page to another page
            }
            else
            {
                Response.Redirect("FailurePage.aspx");
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text = "";
                txt1.Focus();
        }
    }
}