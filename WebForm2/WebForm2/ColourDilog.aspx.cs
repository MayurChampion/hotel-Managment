using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm2
{
    public partial class ColourDilog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Color1_Textchanged(object sender, EventArgs e)
        {
            div1.Attributes.Add("style","background-color:" + color1.Text);
        }
    }
}