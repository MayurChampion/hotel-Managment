using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Configuration;

namespace Ado.net
{
    public partial class ASPDB_Customer_Select : System.Web.UI.Page
    {
        DataSet ds;
        int RowIndex=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerDS"] == null)
            {
                //SqlConnection con = new SqlConnection("Data Source=mayur;Database=ASPDB;Integrated Security = SSPI ");
                //SqlCommand cmd = new SqlCommand("select Custid,Name,Balance,City,Status from customer order by custid",con);
                //SqlDataAdapter da = new SqlDataAdapter(cmd); //pass comnd to adapter//The SqlDataAdapter works with the SqlCommand class to execute SQL commands and retrieve data into a DataSet, 


                //SqlConnection con = new SqlConnection("Data Source=mayur;Database=ASPDB;Integrated Security = SSPI ");
                //SqlDataAdapter da = new SqlDataAdapter("select Custid,Name,Balance,City,Status from customer order by custid", con);  // command object create resposibility is SqlDataAdapter


                //configure in web.config file



                //string ConStr = ConfigurationManager.ConnectionStrings["ASPDBCS"].ConnectionString;//this is one class ConfigurationManager  namespace using System.Configuration;

                SqlDataAdapter da = new SqlDataAdapter("select Custid,Names,Balance,City,Status from customer order by custid", ReadCS.ASPDB);//connection object create resposibility is SqlDataAdapter
                ds = new DataSet(); // comd is empty da.fill
                da.Fill(ds, "Customer");  // fill the data keep in ds dataset
                Session["CustomerDS"] = ds; //  i want use this next request store this in a session datset store in session 
                Session["RowIndex"] = RowIndex;
                //Session storage mechanism for the DataSet 
                //  In ASP.NET, Session["CustomerDS"] = ds assigns a DataSet(ds) to a session variable named "CustomerDS".This means that the DataSet object ds will be stored in the user's session and can be accessed across different pages or requests within the same session.
                // 3 step  create SqlDataAdapter object pass constructor parameter sqlcommand and connection
                // create empty dataset
                // call  fill method and fill method load into data inside the datase
                //Not open and close
                // connection open data loaded and connection close
                ShowData();


            }
            else
            {
                ds = (DataSet)Session["CustomerDS"];
                RowIndex = (int)Session["RowIndex"];
            }
           
        }
        private void ShowData()
        {
            txtId.Text = ds.Tables[0].Rows[RowIndex]["Custid"].ToString();  // data holding in object format so use convert string
            txtName.Text = ds.Tables[0].Rows[RowIndex]["Names"].ToString();
            txtBalance.Text = ds.Tables[0].Rows[RowIndex]["Balance"].ToString();
            txtCity.Text = ds.Tables[0].Rows[RowIndex]["City"].ToString();
            cbStatus.Checked = (bool)ds.Tables[0].Rows[RowIndex]["Status"];
            Session["RowIndex"] = RowIndex;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (RowIndex < ds.Tables[0].Rows.Count - 1)
            {
                RowIndex += 1;
              
                ShowData();
               

        }
            else
            {
                Response.Write("<script>alert('last record of table')</script>");
            }
}

        protected void btnPrev_Click(object sender, EventArgs e)
        {
            if (RowIndex > 0)
            {
                RowIndex -= 1;
                ShowData();
            }
            else
            {
                Response.Write("<script>alert('You are at first record of the table.')</script>");
            }

        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            RowIndex = 0;
            ShowData();

        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            RowIndex = ds.Tables[0].Rows.Count - 1;
            ShowData();

        }
    }
}