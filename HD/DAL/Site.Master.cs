using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HD.DAL
{
    public partial class Site : System.Web.UI.MasterPage
    {
        Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = string.Concat(config.AppSettings.Settings["Titulo"].Value, "-", config.AppSettings.Settings["Aplicacion"].Value);
            lblAplicacion.Text = config.AppSettings.Settings["Aplicacion"].Value;
            lblEmpresa.Text = config.AppSettings.Settings["Titulo"].Value;
            lblLogo.Text = config.AppSettings.Settings["Titulo"].Value;
            Image1.ImageUrl = config.AppSettings.Settings["Isotipo"].Value;
            ltLogo.Text = string.Format("<link rel=\"icon\" type=\"image/png\" sizes=\"16x16\" href=\"{0}\">", config.AppSettings.Settings["Logo"].Value);
        }
    }
}