using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class ValidationField2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rvDate.MinimumValue = DateTime.Now.ToShortDateString();
            rvDate.MaximumValue = DateTime.Now.AddDays(90).ToShortDateString();
            if (!IsPostBack)
            {
                txtName.Focus();
            }
        }

        protected void imgbtn_Click(object sender, ImageClickEventArgs e)
        {
            if (cld.Visible)
            {
                cld.Visible = false;
            }
            else
            {
                cld.Visible = true;
            }
        }

        protected void cld_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = cld.SelectedDate.ToShortDateString();//SelectedDate different SelectedDates 
            cld.Visible = false;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                lblMsg.Text = "Your booking is confirmed.";
            }
            else
            {
                lblMsg.Text = "Validations failed please re-check your data.";
            }
        }
    }
}
