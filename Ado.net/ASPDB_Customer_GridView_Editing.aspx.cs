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
    public partial class ASPDB_Customer_GridView_Editing : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=mayur;Database=ASPDB;Integrated Security = SSPI ");//create object and connection is join
            cmd = new SqlCommand();
            cmd.Connection = con;
            if (!IsPostBack)
                LoadData();
        }
        private void LoadData()
        {
            cmd.CommandText = "select * from customer where status=1 order by custid";
           if(con.State!=ConnectionState.Open)
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;  //e.NewEditIndex; usr selected row and edit and assign in GridView1.EditIndex
            LoadData();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int Custid = int.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text); // GridView1.Rows[e.RowIndex] which row selected  .Cells[0]  which column selected // .Cells[0].Text  column text
                string Name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
                decimal Balance = decimal.Parse(((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
                string City = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
              
                cmd.CommandText =
                         $"Update Customer Set Name='{Name}', Balance={Balance}, City='{City}' Where Custid={Custid}";
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    GridView1.EditIndex = -1;
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message.Replace("'", "") + "')</script>");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int Custid = int.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);
                cmd.CommandText = $"Update Customer Set Status=0 Where Custid={Custid}";
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message.Replace("'", "") + "')</script>");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }

        }
    }
}