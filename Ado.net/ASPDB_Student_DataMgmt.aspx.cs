using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;  
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;   // filehandling this namespace


namespace Ado.net
{
    public partial class ASPDB_Student_DataMgmt : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlConnection con;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtId.Focus();
            }
            con = new SqlConnection("Data Source=mayur;Database=ASPDB;Integrated Security = SSPI");
            cmd = new SqlCommand();
            cmd.Connection = con;

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = $"select Sid ,Name,Class,Fees,PhotoName,PhotoBinary from student where Sid = {txtId.Text}";
                con.Open();
               
             SqlDataReader dr=cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["Name"].ToString();
                    txtClass.Text = dr["Class"].ToString();
                    txtFees.Text = dr["Fees"].ToString() ;
                    imgPhoto.ImageUrl = dr["PhotoName"].ToString();
                    if (dr["PhotoName"] != DBNull.Value)
                    {
                        imgPhoto.ImageUrl = dr["PhotoName"].ToString();
                        Session["PhotoName"] = dr["PhotoName"].ToString();

                    }
                    else
                    {
                        imgPhoto.ImageUrl = null;
                        Session["PhotoName"] = null;
                    }
                  
                    
                    
                    
                    if (dr["PhotoBinary"] != DBNull.Value)
                    {
                        Session["PhotoBinary"] = (byte[])dr["PhotoBinary"];
                    }
                    else
                    {
                        Session["PhotoBinary"]= null;   
                    }
                }
                else
                {
                    Response.Write("<script>alert('No Student exist with given ID')</script>");
                   
                }

            }
            catch(Exception ex)
            { 
              lblMsgs.Text = ex.Message;    
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into student (Sid ,Name,Class,Fees,PhotoName,PhotoBinary) Values(@Sid ,@Name,@Class,@Fees,@PhotoName,@PhotoBinary)";
                cmd.Parameters.AddWithValue("@Sid",txtId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);   // we are use condition than use parameter 
                cmd.Parameters.AddWithValue("@Class",txtFees.Text);
                cmd.Parameters.AddWithValue("@Fees", txtFees.Text);

                if (Session["photoName"] != null)
                {
                    cmd.Parameters.AddWithValue("@PhotoName", Session["photoName"].ToString());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PhotoName", DBNull.Value);  // value is null Data type compalsary
                    //if null than DBtype compalsary  // not null db tye is optinal
                    cmd.Parameters["@photoName"].SqlDbType = SqlDbType.VarChar;
                }

                if (Session["PhotoBinary"] != null)
                {
                    cmd.Parameters.AddWithValue("@PhotoBinary", (byte[])Session["PhotoBinary"]); ;

                }
                else
                {
                    cmd.Parameters.AddWithValue("@PhotoBinary",DBNull.Value);
                    cmd.Parameters["@PhotoBinary"].SqlDbType=SqlDbType.VarBinary; 
                }
                con.Open(); 
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Record Insert into table')</script>");
            }
            catch(Exception ex)
            {
                 lblMsgs.Text=ex.Message;
            }
            finally
            { 
              con.Close();
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                cmd.CommandText = "update Student Set Name=@Name,class=@class,Fees=@Fees,PhotoName=@PhotoName,PhotoBinary=@PhotoBinary where Sid=@Sid";
                cmd.Parameters.AddWithValue("@Sid", txtId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);   // we are use condition than use parameter 
                cmd.Parameters.AddWithValue("@Class", txtFees.Text);
                cmd.Parameters.AddWithValue("@Fees", txtFees.Text);

                if (Session["photoName"] != null)
                {
                    cmd.Parameters.AddWithValue("@PhotoName", Session["photoName"].ToString());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@PhotoName", DBNull.Value);  // value is null Data type compalsary
                    //if null than DBtype compalsary  // not null db tye is optinal
                    cmd.Parameters["@photoName"].SqlDbType = SqlDbType.VarChar;
                }

                if (Session["PhotoBinary"] != null)
                {
                    cmd.Parameters.AddWithValue("@PhotoBinary", (byte[])Session["PhotoBinary"]); ;

                }
                else
                {
                    cmd.Parameters.AddWithValue("@PhotoBinary", DBNull.Value);
                    cmd.Parameters["@PhotoBinary"].SqlDbType = SqlDbType.VarBinary;
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Record Insert into table')</script>");
            }
            catch (Exception ex)
            { 
              lblMsgs.Text = ex.Message;
            }
            finally
            { con.Close(); }    
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "Update Student set status=0 where sid" + txtId.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Record Delete from the  table')</script>");
            }
            catch (Exception ex)
            { 
             lblMsgs.Text += ex.Message;
            }
            finally
            { con.Close(); }    
        }  

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)  // check file is select or not 
            {
                //how to capture file information all information of file inside    HttpPostedFile class

                HttpPostedFile selectedFile = FileUpload1.PostedFile;   // selectedFile this frovide file selected information

                // selectedFile.InputStream         //InputStream is handle to the file to read that contain binary data

                string fileExtention= Path.GetExtension(selectedFile.FileName);  // filepath   path class inside GetExtension method provide file entention
                if (fileExtention == ".jpg" || fileExtention == ".bmp" || fileExtention == ".png")
                {
                    string imgName = selectedFile.FileName;  // find a name of the file
                    string folderPath = Server.MapPath("~/images/");
                    if (!Directory.Exists(folderPath))                 // folder is existing or not 
                    {
                        Directory.CreateDirectory(folderPath);         //if folder not existing create a folder
                    }
                    selectedFile.SaveAs(folderPath+imgName);    // save as folderpath and image
                    imgPhoto.ImageUrl = "~/img/" + imgName; //display the image in image control  imgPhoto this is id

                    //image  convert binare and store in session   BinaryReader this clASS disgn from reading contain in binary format  where to read selected file
                    BinaryReader br = new BinaryReader(selectedFile.InputStream);
                    byte[] imgData = br.ReadBytes(selectedFile.ContentLength);      //ReadBytes reading the bite in file location


                   // Save the 2 valu in session
                    Session["PhotoName"] = "~/img/" + imgName;
                    Session["PhotoBinary"]=imgData;   
                }
                else
                {
                    Response.Write("<script>alert('Supported image file formats are .jpg, .bmp and .png only.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please select an image file to upload.')</script>");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}