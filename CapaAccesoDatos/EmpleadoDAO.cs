using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class EmpleadoDAO
    {
        #region "PATRON SINGLETON"
        private static EmpleadoDAO daoEmpleado = null;
        private EmpleadoDAO() { }
        public static EmpleadoDAO getInstance()
        {
            if(daoEmpleado == null)
            {
                daoEmpleado = new EmpleadoDAO();
            }

            return daoEmpleado;
        }
        #endregion

        public Empleado AccesoSistema(String Usuario, String Password)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            Empleado objEmpleado = null;
            SqlDataReader dr = null;
            
            try
            {
                conexion = Conexion.getInstance().conexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", Usuario);
                cmd.Parameters.AddWithValue("@prmPass", Password);
                conexion.Open();

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objEmpleado = new Empleado();
                    objEmpleado.ID = Convert.ToInt32(dr["idEmpleado"].ToString());
                    objEmpleado.Usuario = dr["usuario"].ToString();
                    objEmpleado.Clave = dr["clave"].ToString();
                }
            } catch (Exception ex)
            {
                objEmpleado = null;
                throw ex;
            } finally
            {
                conexion.Close();
            }

            return objEmpleado;
        }
    }
}
