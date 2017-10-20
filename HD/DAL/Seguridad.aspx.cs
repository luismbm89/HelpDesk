using Common.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HD.DAL
{
    public partial class Seguridad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtClaveEncriptada.Text = Security.Encrypt(txtClave.Text, txtLlave.Text);
            }
            catch (Exception ex) { }
        }

        protected void btnDesencriptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtClaveEncriptada.Text = Security.Decrypt(txtClave.Text, txtLlave.Text);
            }
            catch (Exception ex) { }
        }
    }
}