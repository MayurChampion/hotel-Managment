using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlDemo2
{
    public partial class ListControls1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Karnataka"); //DropDownList1 ID
            DropDownList1.Items.Add(new ListItem("Pakistan","c7")); // first overload  internally it creates a “ListItem” 

            CheckBoxList1.Items.Add("Goldan");   //CheckBoxList1 ID
            CheckBoxList1.Items.Add(new ListItem("Silver","color7"));

            RadioButtonList1.Items.Add("UP");   //RadioButtonList1 ID
            RadioButtonList1.Items.Add(new ListItem("Bihar","s7"));

            ListBox1.Items.Add(new ListItem("Appa","b7")); //ListBox1  ID  //Items Property  // Add()  is Mehod of List
            ListBox1.Items.Add("Anil");

            //The Add() method is commonly used to add a single element to a collection
            //append() method is used to add a single element(4) to the existing list, resulting in an updated list.






            DropDownList1.Items.AddRange(new ListItem[]
            {

                new  ListItem("Karachi","c8"),
                new ListItem("Chenai","c9")
            }) ;

          // AddRange() method is commonly used to add multiple elements to a collection, such as a list


        }
    }
}