using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class ArithmeticOper : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if(!IsPostBack)
                txt1.Focus();
        }

        protected void btn_Click(object sender, EventArgs e)
        {
             int num1=Convert.ToInt32(txt1.Text);
            int num2=Convert.ToInt32(txt2.Text);
            int res = 0;
            res=num1+num2;
            lbl3.Text=res.ToString();
        }
    }
}