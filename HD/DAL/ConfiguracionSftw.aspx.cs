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
using System.Xml;

namespace HD.DAL
{
    public partial class ConfiguracionSftw : System.Web.UI.Page
    {
        Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                if (File.Exists(Server.MapPath("~/Configuracion/ConfigConn.xml")))
                {
                    XmlTextReader xlRead = new XmlTextReader(Server.MapPath("~/Configuracion/ConfigConn.xml"));

                    while (xlRead.Read())
                    {
                        xlRead.MoveToElement();
                        string Nombre = xlRead.Name;
                        string Valor = xlRead.Value;
                        int p=xlRead.LinePosition;//78 BD   84 Clave    126 Servidor    149 Usuario
                        switch (p)
                        {
                            case 68:
                                txtBD.Text = xlRead.Value;
                                break;
                            case 84:
                                txtPassword.Text = xlRead.Value;
                                break;
                            case 126:
                                txtServidor.Text = xlRead.Value;
                                break;
                            case 157:
                                txtUsuario.Text = xlRead.Value;
                                break;
                        }
                    }

                    xlRead.Close();
                    xlRead = null;
                }

                    if (File.Exists(Server.MapPath("~/Configuracion/ConfigSystemNames.xml")))
                    {
                        XmlTextReader xlRead = new XmlTextReader(Server.MapPath("~/Configuracion/ConfigSystemNames.xml"));

                        while (xlRead.Read())
                        {
                            xlRead.MoveToElement();
                            string Nombre = xlRead.Name;
                            string Valor = xlRead.Value;
                            int p = xlRead.LinePosition;//65 App 94 Empresa 120 logo 168 Isotipo
                            switch (p)
                            {
                                case 65:
                                    txtTitulo.Text = xlRead.Value;
                                    break;
                                case 94:
                                    txtEmpresa.Text = xlRead.Value;
                                    break;
                            }

                            }

                        xlRead.Close();
                        xlRead = null;
                    }
                            HtmlGenericControl c = (HtmlGenericControl)this.Master.FindControl(("m4"));
                c.Attributes.Add("class", "active");
                }
            }
            catch (Exception ex) { }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            using (XmlWriter xWr = XmlWriter.Create(Server.MapPath("~/Configuracion/ConfigConn.xml")))
            {
                xWr.WriteStartDocument();

                xWr.WriteStartElement("Configuracion");
                xWr.WriteStartElement("Conexion");

                // ADD FEW ELEMENTS.
                xWr.WriteElementString("BD", txtBD.Text);
                xWr.WriteElementString("Clave", txtPassword.Text);
                xWr.WriteElementString("Servidor", txtServidor.Text);
                xWr.WriteElementString("Usuario", txtUsuario.Text);

                xWr.WriteEndElement();          // CLOSE LIST.
                xWr.WriteEndElement();          // CLOSE LIBRARY.

                xWr.WriteEndDocument();         // END DOCUMENT.

                // FLUSH AND CLOSE.
                xWr.Flush();
                xWr.Close();

            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            using (XmlWriter xWr = XmlWriter.Create(Server.MapPath("~/Configuracion/ConfigSystemNames.xml")))
            {
                xWr.WriteStartDocument();

                xWr.WriteStartElement("Sistema");
                xWr.WriteStartElement("Nombres");

                // ADD FEW ELEMENTS.
                xWr.WriteElementString("Titulo", txtTitulo.Text);
                xWr.WriteElementString("Aplicacion", txtEmpresa.Text);
            string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            string ext1 = System.IO.Path.GetExtension(FileUpload2.PostedFile.FileName);
            if (ext.ToUpper().Equals(".PNG"))
            {
                if (FileUpload1.HasFile)
                {
                   string filename = Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath(string.Format("assets/img/{0}",filename)));
                    xWr.WriteElementString("Logo", string.Format("assets/img/{0}", filename));
                }
            }
            if (ext1.ToUpper().Equals(".PNG"))
            {
                if (FileUpload2.HasFile)
                {
                    string filename = Path.GetFileName(FileUpload2.FileName);
                    FileUpload2.SaveAs(Server.MapPath(string.Format("assets/img/{0}", filename)));
                        xWr.WriteElementString("Isotipo", string.Format("assets/img/{0}", filename));
                }
            }

                xWr.WriteEndElement();          // CLOSE LIST.
                xWr.WriteEndElement();          // CLOSE LIBRARY.

                xWr.WriteEndDocument();         // END DOCUMENT.

                // FLUSH AND CLOSE.
                xWr.Flush();
                xWr.Close();

            }
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