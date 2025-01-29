using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ado.net
{
    public partial class Hotel_Registration : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                txtFN.Focus();  
            
        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
           
            string gender;
            int age = int.Parse(txtAge.Text);
            
            if (rbMale.Checked)
            {
                gender = rbMale.Text;
            }
            else if (rbFemale.Checked)
            {
                gender = rbFemale.Text;
            }
            else
            {
                gender = other.Text;
            }

            string Languages = "";
            if (cbEnglish.Checked==true)
            {
                Languages= Languages + cbEnglish.Text;
            }
            if (cbMarathi.Checked==true)
            {
                Languages= Languages + cbMarathi.Text;
            }
            else
            {
                Languages=cbHindi.Text;
            }
            SqlConnection con = new SqlConnection("Data Source=mayur;Database=hotel_management;Integrated Security = SSPI");
            SqlCommand cmd  = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = $"insert into users values('{txtFN.Text}','{txtLN.Text}','{txtusername.Text}','{gender}','{txtPassW.Text}','{txtemail.Text}','{txtPhone.Text}','{txtADD.Text}',{age},'{Languages}','{ddlCountry.SelectedValue}')";
             if (cmd.ExecuteNonQuery()>0)
            {
                Response.Redirect("Registration_Success.aspx");
            }
            else
            {
                Response.Write("<script>alert('failed to registration')</script>");
               
            }
            con.Close();
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
           Response.Redirect("registration_success.aspx");

        }
      
    }
}