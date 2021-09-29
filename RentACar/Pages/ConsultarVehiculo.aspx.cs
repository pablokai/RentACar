using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;

namespace RentACar.Pages
{
    public partial class ConsultarVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionSQL ms = new ConexionSQL();
                DataTable dt = new DataTable();

                string placa = txtBuscar.Value.ToString();
                Boolean revisar = ms.verificarVehiculo(placa);


                if(revisar == true)
                {
                    dt = ms.consultarVehiculo(placa);
                    gvDatos.DataSource = dt;
                    gvDatos.DataBind();
                    gvDatos.Visible = true;
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