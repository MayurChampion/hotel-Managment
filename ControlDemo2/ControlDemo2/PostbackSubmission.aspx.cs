using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class _1_PostbackSubmission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtName.Focus();
            }


        }

        protected void bntSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPwd.Text == "admin#123" && txtEmail.Text == "admin@nareshit.com")
            {
                lblStatus.Text = "Valid User";
            }
            else
            {
                lblStatus.Text = "Invalid User";
            }

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPwd.Text = txtEmail.Text = "";
            txtName.Focus();

        }
    }
}