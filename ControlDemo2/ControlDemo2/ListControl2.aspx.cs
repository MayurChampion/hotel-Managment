using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ControlDemo2
{
    public partial class ListControl2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //how to read values listcontrol2

                string FilePath = Server.MapPath("~/Product.xml");  // virtual path(virtual path means this folder path only) return Physical path (Physical path means actual path)// XML also teble only //Server.MapPath() is a method in ASP.NET that is used to convert a virtual (or relative) path to an absolute physical path on the server


                // dataset class holding tha data in table form
                //dataset class present under system.data
                //dataset capable  holding multiple data

                //First create instanse of the class and call ReadXml()
                DataSet ds = new DataSet();
                ds.ReadXml(FilePath);   // pass the path of the file all data come into dataset find information inside the dataset// ReadXml() is a method in .NET used for reading XML data into a DataSet or DataTable

                DropDownList1.DataSource = ds.Tables["Product"]; //	By using “DataSource” property of List Control’s we can assign values from any DataSource like a File or Database also
                                                                 //  DropDownList1.DataSource = ds.Tables[0];    we can use index also

                DropDownList1.DataTextField = "name"; // name caolumn should be the  text field
                DropDownList1.DataValueField = "id";    // id caolumn should be the  value field
                DropDownList1.DataBind(); // databind tell full the data what is this
                DropDownList1.Items.Insert(0, "Select Product");// index of 0  position

                ListBox1.DataSource = ds.Tables["Product"];
                ListBox1.DataTextField = "name";
                ListBox1.DataValueField = "id";
                ListBox1.DataBind();

                RadioButtonList1.DataSource = ds.Tables["Product"];
                RadioButtonList1.DataTextField = "name";
                RadioButtonList1.DataValueField = "id";
                RadioButtonList1.DataBind();

                CheckBoxList1.DataSource = ds.Tables["Product"];
                CheckBoxList1.DataTextField = "name";
                CheckBoxList1.DataValueField = "id";
                CheckBoxList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex > 0)
            {
                ListItem item = DropDownList1.SelectedItem;  // DropDownList1 in side selectediterm
                Label1.Text = item.Value + item.Text;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (int i in ListBox1.GetSelectedIndices()) //this is a method present under “ListBox” control that returns an array of indices corresponding to the SelectedItems.	
                str += ListBox1.Items[i].Value + ":" + ListBox1.Items[i].Text + "<br>";
                  Label2.Text = str;  
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex >= 0)
            {
                ListItem item = DropDownList1.SelectedItem;
                Label3.Text = item.Value +":"+ item.Text;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    str += item.Value + ":" + item.Text + "<br>";
                    Label4.Text = str;
                }
            }
        }
    }
}