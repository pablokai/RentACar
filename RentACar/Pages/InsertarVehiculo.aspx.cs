using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class InsertarVehiculo : System.Web.UI.Page
    {

        ConexionSQL ms = new ConexionSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Response.Redirect("Logon.aspx");
                }


                ddlMarca.DataSource = ms.Marca();
                ddlMarca.DataTextField = "marca";
                ddlMarca.DataValueField = "marca";
                ddlMarca.DataBind();

                ddlModelo.DataSource = ms.Modelo();
                ddlModelo.DataTextField = "modelo";
                ddlModelo.DataValueField = "modelo";
                ddlModelo.DataBind();


                ddlColor.DataSource = ms.Color();
                ddlColor.DataTextField = "color";
                ddlColor.DataValueField = "color";
                ddlColor.DataBind();


                ddlCombustible.DataSource = ms.Combustible();
                ddlCombustible.DataTextField = "combustible";
                ddlCombustible.DataValueField = "combustible";
                ddlCombustible.DataBind();


                ddlTipo.DataSource = ms.Tipo();
                ddlTipo.DataTextField = "tipo";
                ddlTipo.DataValueField = "tipo";
                ddlTipo.DataBind();

            }

                




        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
               

                string placa = txtPlaca.Value.ToString();
                string modelo = ddlModelo.SelectedValue.ToString();
               string marca = ddlMarca.SelectedValue.ToString();
                string annio = txtAnnio.Value.ToString();
                string estado = ddlEstado.SelectedValue.ToString();
                string color = ddlColor.SelectedValue.ToString();
                string combustible = ddlCombustible.SelectedValue.ToString();
                float costo = float.Parse(txtCosto.Value.ToString() );
                string tipo = ddlTipo.SelectedValue.ToString();

                if(estado == "Seleccione..." || combustible == "Seleccione..." || tipo == "Seleccione...")
                {
                    lblMensajeError.Visible = true;

                }
                else
                {
                    ms.agregarDatos(placa, modelo, marca, annio, estado, color, combustible, costo, tipo);
                    lblSuccess.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar los datos  " + ex.Message);
                lblError.Visible = true;
            }
        }
    }
}