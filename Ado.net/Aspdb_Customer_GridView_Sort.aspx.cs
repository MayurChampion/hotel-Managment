using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ado.net
{
    public partial class Aspdb_Customer_GridView_Sort : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomersDS"] == null)
            {
                string ConStr = ConfigurationManager.ConnectionStrings["ASPDBCS"].ConnectionString;
                SqlDataAdapter da = new SqlDataAdapter("select Custid,Names,Balance,City,Status from customer order by custid", ConStr);
                ds = new DataSet();
                da.Fill(ds, "customer");
                Session["CustomersDS"] = ds;
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                ds = (DataSet)Session["CustomersDS"];
            }
        }
        // sorting means table heading clickable

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)  // sorting event
        {
            //   e.SortExpression   this property tell you the column the user selected  for the sorting
           //   dataView identical to view in database filter the data that is present inside the table
           // table inside 100 row and 100 colun but requirment acssecc only few  row and column use sorting

        }
    }

}