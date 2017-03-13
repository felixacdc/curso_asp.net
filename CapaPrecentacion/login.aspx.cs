﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogicaNegocio;

namespace CapaPrecentacion
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Empleado objEmpleado = EmpleadoLN.getInstance().AccesoSistema(txtUsuario.Text, txtPassword.Text);

            if(objEmpleado != null)
            {
                Response.Write("<script>alert('Usuario Correcto')</script>");
            } else
            {
                Response.Write("<script>alert('Usuario Incorrecto')</script>");
            }
        }
    }
}