using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class RadioAndCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if(!IsPostBack)
                txtName.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           StringBuilder sb = new StringBuilder();  //create object string builder
            if (txtName.Text.Trim().Length > 0)        //txtName tjis is ID and this textbox Text read this text>0
                sb.Append("Name : "+txtName.Text+"<br/>");

            if (rbMale.Checked)
                sb.Append("Gender:Male <br/>");
            else if (rbFemale.Checked)
                sb.Append("Gender:female<br/>");
            else if (rbTrans.Checked)
                sb.Append("Gender:Transgender <br/>");

            if (rbVeg.Checked)
                sb.Append("Eating Habbit: Vegeteerian");
            else if (rbNonveg.Checked)
                sb.Append("Eating Habbit : Non-Vegeteerian");
            else if (rbVegan.Checked)
                sb.Append("Eating Habbit:Vegan<br/>");

             List<string> hobbies = new List<string>();
            if (cbReading.Checked)
                hobbies.Add("Reading Books");
            if (cbPlaying.Checked)
                hobbies.Add("Playing Games");
            if (cbWatching.Checked)
                hobbies.Add("Watching movies");

            if (hobbies.Count > 0)
                sb.Append("Hobbies:"+string.Join(",",hobbies));

            lblMsg.Text = sb.ToString();
        }
    }
}