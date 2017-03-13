﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null;
        private Conexion()
        {

        }

        public static Conexion getInstance()
        {
            if(conexion == null)
            {
                conexion = new Conexion();
            }

            return conexion;
        }
        #endregion

        public SqlConnection conexionBD()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=1CAE-GUA-PC152\\SQLEXPRESS;Initial Catalog=DBClinica_test; Integrated Security = True";
            return conexion;
        }
    }
}
