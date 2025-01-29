using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm2
{
    public partial class Calculatr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtNum1.Focus();
            }
        }

        protected void btn1_Click(object sender, EventArgs e) 
        {
         
            int num1 = int.Parse(txtNum1.Text);  // text ha string thatwhy converstion
            int num2 = int.Parse(txtNum2.Text);
            int result = 0;
            Button b = (Button)sender;
            switch (b.ID)
            {
                case "btn1":
                  result=num1+ num2;
                    break;
                case "btn2":
                    result = num1 - num2;
                    break;
                case "btn3":
                    result = num1 * num2;
                    break;
                case "btn4":
                    result = num1 / num2;
                    break;
                case "btn5":
                    result = num1 % num2;
                    break;
            }
            txtResult.Text=result.ToString();   // result is text means string so Tostring
           
        } 
    }
}    