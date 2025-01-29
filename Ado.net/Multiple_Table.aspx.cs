using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Ado.net
{
    public partial class Multiple_Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=mayur;Database=ASPDB;Integrated Security = SSPI ");
            SqlCommand cmd = new SqlCommand("Select * from Department;select * from emp", con);
            con.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            // right using grid view

            gvdepartment.DataSource = dr;
            gvdepartment.DataBind(); // DataBind() data will be bound
           
            dr.NextResult();  // move to next table

            gvemp.DataSource = dr;
            gvemp.DataBind();
             
            con.Close();



        }
    }
}