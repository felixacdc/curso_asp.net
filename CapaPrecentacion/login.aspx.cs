using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string password = txtPassword.Text;
            string userName = "Felix";
            string passName = "12345";

            if(user.Equals(userName) && password.Equals(passName))
            {
                Response.Write("<script>alert('Usuario correcto')</script>");
            } else
            {
                Response.Write("<script>alert('Usuario incorrecto')</script>");
            }
        }
    }
}