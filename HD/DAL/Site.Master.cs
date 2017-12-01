using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace HD.DAL
{
    public partial class Site : System.Web.UI.MasterPage
    {
        Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
        protected void Page_Load(object sender, EventArgs e)
        {
            string titulo = "", App = "", isotipo = "", logo = "";
            if (!Page.IsPostBack)
            {
                if (!Page.IsPostBack)
                {

                    if (File.Exists(Server.MapPath("~/Configuracion/ConfigSystemNames.xml")))
                    {
                        XmlTextReader xlRead = new XmlTextReader(Server.MapPath("~/Configuracion/ConfigSystemNames.xml"));

                        while (xlRead.Read())
                        {
                            xlRead.MoveToElement();
                            string Nombre = xlRead.Name;
                            string Valor = xlRead.Value;
                            string p = xlRead.BaseURI;//65 App 94 Empresa 120 logo 168 Isotipo
                            switch (p)
                            {
                            }

                        }

                        xlRead.Close();
                        xlRead = null;
                    }
                    Page.Title = string.Concat(titulo, "-", App);
                    lblAplicacion.Text = App;
                    lblEmpresa.Text = titulo;
                    lblLoginEmpresa.Text = titulo;
                    lblTittleLogin.Text = titulo;
                    lblLogo.Text = titulo;
                    Image1.ImageUrl = isotipo;
                    ltLogo.Text = string.Format("<link rel=\"icon\" type=\"image/png\" sizes=\"16x16\" href=\"{0}\">", logo);
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
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["User"] = txtUsuario.Text;
            Response.Redirect("default.aspx");
        }
    }
}