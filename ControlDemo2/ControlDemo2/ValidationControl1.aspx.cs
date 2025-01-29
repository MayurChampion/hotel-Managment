using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class ValidationControl1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtName.Focus();
            }
            // Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            txtName.Attributes.Add("onblur", "ValidatorValidate(rvfName)");  // Focus not Comeing the textbox 
            ddlContries.Attributes.Add("onblur", "ValidatorValidate(rfvCountry)");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // if (rfvName.IsValid && rfvCountry.IsValid)//rfvName,rfvCountry  this  is validation ID
            if (IsValid)// should all are true
            {
                lbl.Text = $"Hello {txtName.Text},the Country you belongs {ddlContries.SelectedItem}";

            }
            else
            {
                lbl.Text = "Data Validation Failed";
            }
            // First check client side validation  is false unsuccsessful than stop  not go to server side and client side validation is succsessful than go to server side validation Biuty of validation ( IsValid )  

        }
    }
}