using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class Validations4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                TextBox1.Focus();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                lblmsg.Text = "Your company registration is successful";
            }
            else
            {
                lblmsg.Text = "Your company registration failed because validations failed.";
            }
        }
    }
}