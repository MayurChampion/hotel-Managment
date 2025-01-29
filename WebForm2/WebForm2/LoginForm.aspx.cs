using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm2
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                txtName.Focus();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Mayur" && TxtEmail.Text == "patil@gmail.com" && TxtPwd.Text == "123456")
            {
                lblStatus.Text = "Valid User";

            }
            else
            {
                lblStatus.Text = "Invalid User";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtName.Text = TxtEmail.Text = TxtPwd.Text = "";
        }
    }
}