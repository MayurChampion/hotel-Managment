using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Text.RegularExpressions;
using System.Data;

namespace Ado.net
{
    public partial class ASPDB_employee_insert : System.Web.UI.Page
    {
       SqlConnection con;    // global declaration mens use multiple time local declaration only one time
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=mayur;Database=master;Integrated Security = SSPI ");
            cmd = new SqlCommand(); // Default Constructor
             cmd.Connection = con;  // constructor 1 parameter
            if (!IsPostBack)
            {
                txtName.Focus();
                LoadDepts();
            }
        }
        private void LoadDepts()
        {
            cmd.CommandText = "Select Did ,Dname from Department order by did"; // sqlcommand 2 parameter   // here select a data in department table and store in sqlDatareader
            con.Open();
           SqlDataReader dr = cmd.ExecuteReader();

            //ddlDept is id of Dropdownlist
            //DataTextField also member of  Dropdownlist

            ddlDept.DataSource = dr;  //DataSource: This property is used to assign a data source to the control.   // here  accseing value in Sqldatareader and store datasoures and inside the datsourse assign value in dropdownlist
            ddlDept.DataTextField = "DName";
            ddlDept.DataValueField= "Did";
            ddlDept.DataBind();
            ddlDept.Items.Insert(0, "-Select Department-");

            con.Close();
        }
         
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (ddlDept.SelectedIndex > 0)  // select department  than  execute start index 1
            {
                cmd.CommandText = $"Insert Into Employee Values('{txtName.Text}','{txtJob.Text}',{txtSalary.Text},{ddlDept.SelectedValue})";  // dynamic value insert
                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.CommandText = "Select Max(Eid) From Employee";     // aaccseing max empid and assing txtid
                    txtId.Text = cmd.ExecuteScalar().ToString();     // ExecuteScalar() This method is commonly used when you expect a query to return a single result, typically an aggregate function like COUNT(), MAX(), MIN(), or any other query that returns a single value.
                }
                else
                {
                    Response.Write("<script>alert('failed inserting record into table')</script>");
                }
                con.Close();
            }
            else
            {
                Response.Write("<script>alert('plase select department id')</script>");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            
          txtId.Text = txtName.Text = txtJob.Text = txtSalary.Text = "";
            ddlDept.SelectedIndex = 0;
            txtName.Focus();

        }
    }
}