using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class Validation3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtName.Focus();
            cvMajor.ValueToCompare = DateTime.Now.AddYears(-18).ToShortDateString();
        }

        protected void RegBtn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Text = "Your registration is successful.";
            }
            else
            {
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Text = "Validations failed please re-check your data.";


            }
        }

        protected void imgbtn_Click(object sender, ImageClickEventArgs e)
        {
            if (cldDate.Visible)
            {
                cldDate.Visible = false;
            }
            else
            {
                cldDate.Visible = true;
            }

        }

        protected void cal_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = cldDate.SelectedDate.ToShortDateString();
            cldDate.Visible = false;

        }
    }
}