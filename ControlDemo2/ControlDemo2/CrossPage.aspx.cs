using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class CrossPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtName.Focus();
            }

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = txtPhone.Text = txtEmail.Text = "";
            txtName.Focus();

        }
    }
}