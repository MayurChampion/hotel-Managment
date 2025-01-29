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
    public partial class ASPDB_Customer_GridView_Editing_Sp : System.Web.UI.Page
    {
        Customer obj = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                LoadData();
        }

        private void LoadData()
        {
            GridView1.DataSource = obj.Customer_Select(null, null);
            GridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int custid = int.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);
            int Custid = int.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);
            if (obj.Customer_Delete(Custid) > 0)
            {
                LoadData();
            }
            else
            {
                Response.Write("<script>alert('Failed deleting the record from table.')</script>");
            }

        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadData();

        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadData();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // read 4 value
            int Custid = int.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);// int.parse means text is string so use // hole gridView inside edit row  // this no edit only readonly so not use control  //Rows[e.RowIndex] means  e.RowIndex  refer to which row you edit this row index
            string Name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            decimal Balance = decimal.Parse(((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            string city = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            bool status = ((CheckBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Checked;
            if (obj.Customer_Update(Custid, Name, Balance, city) > 0)
            {
                GridView1.EditIndex = -1;
                LoadData();
            }
            else
            {
                Response.Write("<script>alert('Failed updating the record in table.')</script>");


            }
        }
    }
}
