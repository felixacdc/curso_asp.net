using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPrecentacion
{
    public partial class frmGestionarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        private void GetValues()
        {
            Paciente objPaciente = new Paciente();
            objPaciente.IdPaciente = 0;
        }

        private Paciente GetPaciente()
        {
            return null;
        }
    }
}