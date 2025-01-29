using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ControlDemo2
{
    public partial class ConfigurDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  need configure file how to read configure file 
            //  ConfigurationManager this is class  this namespace using System.Configuration

            lblTitle.Text = ConfigurationManager.AppSettings.Get("companyName"); // get provide the keyname
            lblAddress.Text = ConfigurationManager.AppSettings.Get("Address");
            lblContact.Text = ConfigurationManager.AppSettings.Get("Contact");
        }
    }
}