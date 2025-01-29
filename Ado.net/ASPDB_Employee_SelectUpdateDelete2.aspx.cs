using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ado.net
{
    public partial class ASPDB_Employee_SelectUpdateDelete2 : System.Web.UI.Page
    {
        SqlDataReader dr;// load emp and load department also mhanun globabal declaration
        SqlCommand cmd;
        SqlConnection con;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=mayur;Database=ASPDB;Integrated Security = SSPI ");//create object and connection is join
            cmd = new SqlCommand(); // create object Sqlcommand class
            cmd.Connection = con;  //parameter of sqlcommand class
            if (!IsPostBack)
            {
                LoadEmps();     //fetch data in emp table and put data in emp dropdownlist
                LoadDepts();     //fetch data in dept table and put data in dept dropdownlist
            }
        }
        protected void LoadEmps() //create method seprate
        {
            cmd.CommandText = "select Empid from Emp Order by Empid"; //command class parameter  and right query select Did,dname from department
            if(con.State!=System.Data.ConnectionState.Open) // repart connection open is not allow so use this state  
            con.Open();        //connectin is open
            dr = cmd.ExecuteReader();  // query excute for right ExecuteReader() method  excute after store data in dr 
            ddlEmp.DataSource = dr; //dr inside data store in DataSource class
            ddlEmp.DataTextField = "Empid";
            ddlEmp.DataValueField = "Empid";
            ddlEmp.DataBind();
            ddlEmp.Items.Insert(0, "-Select Employee-"); // dropdownlist inside 0 index put select deprtment
            con.Close();// data is loaded so connection is close

        }
        private void LoadDepts()
        {
            cmd.CommandText = "Select Did,Dname from Department order by did"; // sqlcommand 2 parameter
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            //ddlDept is id of Dropdownlist
            //DataTextField also member of  Dropdownlist

            ddlDept.DataSource = dr;
            ddlDept.DataTextField = "Dname";
            ddlDept.DataValueField = "Did";  // DataValueField not viseble
            ddlDept.DataBind();
            ddlDept.Items.Insert(0, "-Select Department-");

            con.Close();
        }

        protected void ddlEmp_SelectedIndexChanged(object sender, EventArgs e)  // ddlEmp_SelectedIndexChanged  defaul event in the dropdown list when the event fire select iterm in the list
        {

            if (ddlEmp.SelectedIndex > 0)
            {
                cmd.CommandText = "select empname,empjob,did,salary from emp where empid=" + ddlEmp.SelectedValue;
                con.Open();
                dr = cmd.ExecuteReader();                                       // acassecss the data in emp table and  store datareader
                if (dr.Read())   // mean data is existing or not  data is existing than go inside
                {
                    txtName.Text = dr["empname"].ToString();

                    txtJob.Text = dr["empjob"].ToString();                          // assing value in textboxes
                   
                    txtSalary.Text = dr["salary"].ToString();

                    ddlDept.SelectedValue = dr["did"].ToString();  // deptment inside did on  deoatrmrnt name come
                    con.Close();
                }
                else
                {
                    Response.Write("<script>alert('selectted emp-id is not existing in the database')</script>");
                    txtName.Text = txtJob.Text = "";
                    ddlDept.SelectedIndex = 0;
                    dr.Close(); // here  LoadEmps(); method call so first is close and repiat methos is call
                    LoadEmps();  // some delete the data so again loademps() data in dropdownlist
                }
            }
            else
            {
                txtName.Text = txtJob.Text = "";
                ddlDept.SelectedIndex = 0;
                ddlEmp.Focus();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ddlEmp.SelectedIndex > 0)
            { 
                cmd.CommandText =$"update emp set empname= '{txtName.Text}', empjob = '{txtJob.Text}',salary = '{txtSalary.Text}',did = '{ddlDept.SelectedValue}' where empid={ddlEmp.SelectedValue}";
                con.Open();
                // Response.Write(cmd.CommandText);  only chack right or wring
                if (cmd.ExecuteNonQuery() > 0) // update insert delete for use ExecuteNonQuery()
                {
                    Response.Write("<script>alert('Record update in the table.')</script>");
                }
                else
                {
                    Response.Write("<script>alert('failed updating in the table.')</script>");
                }
                con.Close();
            }
            else
            {
                

            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (ddlEmp.SelectedIndex > 0)
            {
                cmd.CommandText = "delete from emp where empid=" + ddlEmp.SelectedValue;
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)  //ExecuteNonQuery() this is return int  no of row effected so 1 row effected true 0 row effected so fales so sucsses or failuare  for chacking use 
                {
                    Response.Write("<script>alert('Record is delete')</script>");
                    //clear all control
                    txtJob.Text = txtName.Text = txtSalary.Text = "";
                    ddlDept.SelectedIndex = 0;
                    //after clear loademp
                    LoadEmps();   // hear not close() because loademps() call load repiat
                    ddlEmp.Focus();
                }
                else
                {
                    Response.Write("<script>alert('failed deleting record from table')</script>");
                    con.Close();
                }
            }
            else
            {
                Response.Write("<script>alert('plase choose an emplyee to delete.')</script>");
            }
            
        }
    }
}
