﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class EmpleadoLN
    {
        #region "PATRON SINGLETON"
        private static EmpleadoLN objEmpleado = null;
        private EmpleadoLN() { }
        public static EmpleadoLN getInstance()
        {
            if(objEmpleado == null)
            {
                objEmpleado = new EmpleadoLN();
            }
            return objEmpleado;
        }
        #endregion

        public Empleado AccesoSistema(String Usuario, String Password)
        {
            try
            {
                return EmpleadoDAO.getInstance().AccesoSistema(Usuario, Password);
            } catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
