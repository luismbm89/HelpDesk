using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HD.DAL
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = string.Concat(Properties.Resources.Titulo,"-",Properties.Resources.Aplicacion);
            lblAplicacion.Text = Properties.Resources.Aplicacion;
            lblEmpresa.Text = Properties.Resources.Titulo;
            lblLogo.Text = Properties.Resources.Titulo;
        }
    }
}