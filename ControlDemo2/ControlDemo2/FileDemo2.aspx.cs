using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace ControlDemo2
{
    public partial class FileDemo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (FileUpload2.HasFile)
            {
                string FolderPath = Server.MapPath("~/uploads/");
                if (!Directory.Exists(FolderPath))              // Directory is one class inside Exists and CreateDirectory this method
                {
                    Directory.CreateDirectory(FolderPath);// container that holds information about files and other directories
                }
                List<HttpPostedFile> selectedfiles= FileUpload2.PostedFiles.ToList(); // HttpPostedFile one class ahe,FileUpload2.PostedFiles upload madhun data gheto ani selectedfiles ya object madhe trhevte
                foreach (HttpPostedFile file in selectedfiles)
                {
                    file.SaveAs(FolderPath +file.FileName);  //  here we save  this folder ( this is folder path FolderPath)+file.name file name also save
                }
                lbl1.Text = selectedfiles.Count + "files uploaded";
            }
        }
    }
}