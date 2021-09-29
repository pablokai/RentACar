using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class EliminarVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Response.Redirect("Logon.aspx");
                }
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL ms = new ConexionSQL();

                string placa = txtEliminar.Value.ToString();
                Boolean revisar = ms.verificarVehiculo(placa);


                if (revisar == true)
                {
                    ms.eliminarVehiculo(placa);
                    lblSuccess.Visible = true;
                }
                else
                {
                    lblMensajeError.Visible = true;
                }



            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos" + ex.Message);
                //lblError.Visible = true;
            }
        }
    }
}