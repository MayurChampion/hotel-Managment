using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class TextChange : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txt_TextChanged(object sender, EventArgs e)
        {
            // textBox inside one Event called as txt_TextChanged
            lbl.Text = txt.Text;
            btn.Text = txt.Text;
            div1.Attributes.Add("style", "background-color:" + txtColor1.Text);// which attribut,value,where you calect
        }
    }
}