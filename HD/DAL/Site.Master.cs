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
            if (!Page.IsPostBack)
            {
                Page.Title = string.Concat(config.AppSettings.Settings["Titulo"].Value, "-", config.AppSettings.Settings["Aplicacion"].Value);
                lblAplicacion.Text = config.AppSettings.Settings["Aplicacion"].Value;
                lblEmpresa.Text = config.AppSettings.Settings["Titulo"].Value;
                lblLoginEmpresa.Text = config.AppSettings.Settings["Titulo"].Value;
                lblTittleLogin.Text = config.AppSettings.Settings["Titulo"].Value;
                lblLogo.Text = config.AppSettings.Settings["Titulo"].Value;
                Image1.ImageUrl = config.AppSettings.Settings["Isotipo"].Value;
                ltLogo.Text = string.Format("<link rel=\"icon\" type=\"image/png\" sizes=\"16x16\" href=\"{0}\">", config.AppSettings.Settings["Logo"].Value);
                if (Session["User"] != null)
                {
                    m2.Visible = true;
                    m3.Visible = true;
                    m4.Visible = true;
                    m5.Visible = true;
                    m6.Visible = true;
                    staskbar.Visible = true;
                    liMessages.Visible = true;
                    liAlarms.Visible = true;
                    liTasks.Visible = true;
                    lilogin.Visible = false;
                    liUser.Visible = true;
                }
                else
                {
                    m2.Visible = false;
                    m3.Visible = false;
                    m4.Visible = false;
                    m5.Visible = false;
                    m6.Visible = false;
                    staskbar.Visible = false;
                    liMessages.Visible = false;
                    liAlarms.Visible = false;
                    liTasks.Visible = false;
                    lilogin.Visible = true;
                    liUser.Visible = false;
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["User"] = txtUsuario.Text;
            Response.Redirect("default.aspx");
        }
    }
}