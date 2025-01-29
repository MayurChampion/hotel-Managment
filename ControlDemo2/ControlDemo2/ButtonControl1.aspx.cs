using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class ButtonControl1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(txt1.Text);
            int Num2 = int.Parse(txt2.Text);
            int result = 0;

            Button b = sender as Button;
            //switch (b.ID)
            //{
            //    case "btn1":
            //        result = Num1 + Num2;
            //        break;
            //    case "btn2":
            //        result = Num1 - Num2;
            //        break;
            //    case "btn3":
            //        result = Num1 * Num2;
            //        break;
            //    case "btn4":
            //        result = Num1 / Num2;
            //        break;

            //}
            if (b.ID == "btn1")
            {
                result = Num1 + Num2;
            }
            else if (b.ID == "btn2")
            {
                result = Num1 - Num2;
            }
            else if (b.ID == "btn3")
            {
                result = Num1 * Num2;
            }
            else if (b.ID == "btn4")
            {
                result = Num1 / Num2;
            }
            lbl1.Text = result.ToString();
        }
    }
}