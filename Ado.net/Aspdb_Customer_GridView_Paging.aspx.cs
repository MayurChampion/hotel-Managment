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
    public partial class Customer_GridView_Paging : System.Web.UI.Page
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
                Session["CustomersDS"] = ds;   //storing dataset into session
                LoadData();
            }
            else
            {
                ds = (DataSet)Session["CustomersDS"];
            }
        }
        private void LoadData()
        {
            gvCustomers.DataSource= ds;
            gvCustomers.DataBind();
        }

        protected void gvCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCustomers.PageIndex= e.NewPageIndex;
            LoadData() ;
        }
    }
}