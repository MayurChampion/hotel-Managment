using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ControlDemo2 
{
    public partial class FileDemo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)  //  hasfile  this method check FileUpload1 inside any folder avilable  
            {
                HttpPostedFile selectedFile = FileUpload1.PostedFile;  //PostedFile this is property call  return inatanse of class  HttpPostedFile  this will return you complete information file that is selected // get access client uploaded file

                // selectedFile.ContentType        // return what type of file like jpg ,png
                // selectedFile.FileName     name of the file
                string folderpath = Server.MapPath("~/uploads/");//last  and first  double / /  this is folder only  single / this is file
                if (!Directory.Exists(folderpath))  // chek folder avilabel or not 
                {
                    Directory.CreateDirectory(folderpath);  // then not avilabel create folder // only one time create
                }
                selectedFile.SaveAs(folderpath + selectedFile.FileName);  // where save
                lbl1.Text = selectedFile.FileName + " : "+"File is uploaded";
            }
            else 
            {
                lbl1.Text = "please select a file upload";
            }
        
         }
    }
}