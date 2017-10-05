using Common.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HD.DAL
{
    public partial class ConfiguracionSftw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                HtmlGenericControl c = (HtmlGenericControl)this.Master.FindControl(("m4"));
                c.Attributes.Add("class", "active");
                if (!Page.IsPostBack)
                {
                    txtBD.Text = Properties.Resources.BD;
                    txtPassword.Text = Security.Encrypt(Properties.Resources.Clave,"HelpDesk");
                    txtServidor.Text = Properties.Resources.Servidor;
                    txtUsuario.Text = Properties.Resources.Usuario;
                }
            }
            catch (Exception ex) { }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {


        }
    }
}