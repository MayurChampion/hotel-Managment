using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Ado.net
{
    public partial class Hotel_registration : System.Web.UI.Page
    {
        SqlConnection con;
        //    SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            //        con = new SqlConnection("Data Source=mayur;Database=hotel_management;Integrated Security = SSPI");
            //        cmd = con.CreateCommand();
            //        cmd.Connection = con;

        }
        //    private void username_chack()
        //    {
        //        cmd.CommandText = $"select username from hotel_Registration where username='{txtUser.Text}'";

        //            con.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            Response.Write("<script>alert('username is already register')</script>");
        //        }
        //        else
        //        {
        //            Insert();
        //        }
        //        con.Close();

        //    }
        //    private void Insert()
        //    {
        //        string room_type;
        //        if (radiobtn1.Checked)
        //        {
        //            room_type = radiobtn1.Text;
        //        }
        //        else
        //        {
        //            room_type = radiobtn2.Text;
        //        }

        //       List<string> list = new List<string>();   
        //        if (CheckBox1.Checked)
        //        {
        //            list.Add(CheckBox1.Text);
        //        }
        //        else if (CheckBox2.Checked)
        //        {
        //            list.Add(CheckBox2.Text);
        //        }
        //        else
        //        {
        //            list.Add( CheckBox3.Text);
        //        }
        //        cmd.CommandText = $"insert into hotel_Registration values('{txtUser.Text}','{room_type}','{list}')";
        //        con.Open();
        //        if (cmd.ExecuteNonQuery() > 0)
        //        {
        //            cmd.CommandText = $"select * from hotel_Registration where username='{txtUser.Text}'";
        //            SqlDataReader dr2 = cmd.ExecuteReader();
        //            Cache["hotel_registration"] = dr2;
        //            Response.Redirect("Welcome.aspx");

        //        }
        //        else
        //        {
        //            Response.Write("<script>alert('failed to registration')</script>");


        //        }
        //        con.Close();

        //    }
        protected void regbtn_Click(object sender, EventArgs e)
        {
            //username_chack();
            con = new SqlConnection("Data Source=mayur;Database=hotel_management;Integrated Security = SSPI");
            SqlDataAdapter da = new SqlDataAdapter($"select username from hotel_Registration where username='{txtUser.Text}'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "hotel_Registration");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Write("<script>alert('username is already register')</script>");
            }
            else
            {
                string room_type;
           
                
                    if (radiobtn1.Checked)
                    {
                        room_type = radiobtn1.Text;
                    }
                    else
                    {
                        room_type = radiobtn2.Text;
                    }

                string iterm = "";
                   if(CheckBox1.Checked==true)
                    iterm= iterm + CheckBox1.Text;  
                   if(CheckBox2.Checked==true)
                    iterm= iterm + CheckBox2.Text;
                    
                     con = new SqlConnection("Data Source=mayur;Database=hotel_management;Integrated Security = SSPI");

                    SqlDataAdapter da2 = new SqlDataAdapter($"insert into hotel_Registration values('{txtUser.Text}','{room_type}','{iterm}')", con);
                    
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2, "hotel_Registration");
                   
                       con = new SqlConnection("Data Source=mayur;Database=hotel_management;Integrated Security = SSPI");
                        SqlDataAdapter da3 = new SqlDataAdapter($"select * from hotel_Registration where username='{txtUser.Text}'", con);
                        DataSet ds3 = new DataSet();
                        da3.Fill(ds3, "hotel_Registration");
                        Cache["hotel_Registration"] = ds3;
                        Response.Redirect("Welcome.aspx");
                    
                    
                }
            }


        }
    }
