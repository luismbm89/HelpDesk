using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HD.DAL
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Literal Ruta = this.Master.FindControl("ltRuta") as Literal;
                Ruta.Text = "<li><i class=\"ace-icon fa fa-home home-icon\"></i><a href = \"default.aspx\"> Inicio </a></li><li class=\"active\">Default</li>";
            }
            catch (Exception ex) { }
            }
    }
}