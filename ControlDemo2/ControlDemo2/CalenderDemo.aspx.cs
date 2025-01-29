using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class CalenderDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                txt1.Focus();
        }

        protected void btnDate_Click(object sender, ImageClickEventArgs e)
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

        protected void cldDate_SelectionChanged(object sender, EventArgs e)
        {
            //calender have default event cldDate_SelectionChanged
            txt1.Text = cldDate.SelectedDate.ToShortDateString(); //  txt1 text box id // cldDate calender id// SelectedDate select the date and assign textbox
            cldDate.Visible=false;
        }
    }
}