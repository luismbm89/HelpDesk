using Common.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HD.DAL
{
    public partial class ConfiguracionSftw : System.Web.UI.Page
    {
        Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                HtmlGenericControl c = (HtmlGenericControl)this.Master.FindControl(("m4"));
                c.Attributes.Add("class", "active");
                if (!Page.IsPostBack)
                {
                    txtBD.Text = config.AppSettings.Settings["BD"].Value;
                    txtPassword.Text = config.AppSettings.Settings["Clave"].Value;
                    txtServidor.Text = config.AppSettings.Settings["Servidor"].Value;
                    txtUsuario.Text = config.AppSettings.Settings["Usuario"].Value;
                    txtTitulo.Text = config.AppSettings.Settings["Titulo"].Value;
                    txtEmpresa.Text = config.AppSettings.Settings["Aplicacion"].Value;
                }
            }
            catch (Exception ex) { }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings.Remove("BD");
            config.AppSettings.Settings.Add("BD", txtBD.Text);
            config.AppSettings.Settings.Remove("Clave");
            config.AppSettings.Settings.Add("Clave", txtPassword.Text);
            config.AppSettings.Settings.Remove("Servidor");
            config.AppSettings.Settings.Add("Servidor", txtServidor.Text);
            config.AppSettings.Settings.Remove("Usuario");
            config.AppSettings.Settings.Add("Usuario", txtUsuario.Text);
            config.Save();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            config.AppSettings.Settings.Remove("Titulo");
            config.AppSettings.Settings.Add("Titulo", txtTitulo.Text);
            config.AppSettings.Settings.Remove("Aplicacion");
            config.AppSettings.Settings.Add("Aplicacion", txtEmpresa.Text);
            string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            string ext1 = System.IO.Path.GetExtension(FileUpload2.PostedFile.FileName);
            if (ext.ToUpper().Equals(".PNG"))
            {
                if (FileUpload1.HasFile)
                {
                   string filename = Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath(string.Format("assets/img/{0}",filename)));
                    config.AppSettings.Settings.Remove("Logo");
                    config.AppSettings.Settings.Add("Logo", string.Format("assets/img/{0}", filename));
                }
            }
            if (ext1.ToUpper().Equals(".PNG"))
            {
                if (FileUpload2.HasFile)
                {
                    string filename = Path.GetFileName(FileUpload2.FileName);
                    FileUpload2.SaveAs(Server.MapPath(string.Format("assets/img/{0}", filename)));
                    config.AppSettings.Settings.Remove("Isotipo");
                    config.AppSettings.Settings.Add("Isotipo", string.Format("assets/img/{0}", filename));
                }
            }
                    config.Save();
            Response.Redirect("ConfiguracionSftw.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            if (ConexionSQL.conexionSQL().State == ConnectionState.Open)
            {
                LinkButton3.Text = "OK!";
            }
            else {

                LinkButton3.Text = "X!";
            }
        }
    }
}