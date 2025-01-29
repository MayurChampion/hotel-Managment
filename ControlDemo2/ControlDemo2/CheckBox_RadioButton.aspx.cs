using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class CheckBox_RadioButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                txt1.Focus();   
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
             string Name = txt1.Text;
            string education = txt2.Text;
            string course;
            string gender;
            if (RadioButton1.Checked)
            {
                course = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                course = RadioButton2.Text;
            }
            else if (RadioButton3.Checked)
            {
                course = RadioButton3.Text;
            }
            else
            {
                course = "Plese Select One Course";
            }

            if (RadioButton4.Checked)
            {
                gender = RadioButton4.Text;
            }
            else if (RadioButton5.Checked)
            {
                gender = RadioButton5.Text;
            }
            else if (RadioButton6.Checked)
            {
                gender = RadioButton6.Text;
            }
            else
            {
                gender = "Plese Select your gender";
            }
            lbl1.Text = $"Name of Student  : {Name}, Education :{txt2.Text}, Course : {course}, Gender :{gender}";
        }
    }
}