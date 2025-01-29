using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace ControlDemo2
{
    public class Global : System.Web.HttpApplication //Global is class hole application apllied parent is HttpApplication
    {                                                 // in this class we can right  some method  standard you can not change 
                                                      //if you right any  logic  in this method this logic execute only first time only when this application is start 
                                                      // this method run and run only one time // in any case application is stop this time application_end method execute
        protected void Application_Start(object sender, EventArgs e)
        { 
            ValidationSettings.UnobtrusiveValidationMode=UnobtrusiveValidationMode.None; // application level
        }
    }
}