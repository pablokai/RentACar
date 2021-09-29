using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class ModificarVehiculo : System.Web.UI.Page
    {

        ConexionSQL mt = new ConexionSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {
                    if (Session["Login"] == null)
                    {
                        Response.Redirect("Logon.aspx");
                    }


                    lblTipo.Visible = false;
                    lblModelo.Visible = false;
                    lblMarca.Visible = false;
                    lblAnnio.Visible = false;
                    lblColor.Visible = false;
                    lblEstado.Visible = false;
                    lblCosto.Visible = false;
                    lblCombustible.Visible = false;

                    ddlModelo.Visible = false;
                    ddlMarca.Visible = false;
                    txtAnnio.Visible = false;
                    ddlColor.Visible = false;
                    txtCosto.Visible = false;
                    ddlCombustible.Visible = false;
                    ddlEstado.Visible = false;
                    ddlTipo.Visible = false;
                    bloque.Visible = false;
                    titulo.Visible = false;

                    btnModificar.Visible = false;

                    ddlMarca.DataSource = mt.Marca();
                    ddlMarca.DataTextField = "marca";
                    ddlMarca.DataValueField = "marca";
                    ddlMarca.DataBind();

                    ddlModelo.DataSource = mt.Modelo();
                    ddlModelo.DataTextField = "modelo";
                    ddlModelo.DataValueField = "modelo";
                    ddlModelo.DataBind();


                    ddlColor.DataSource = mt.Color();
                    ddlColor.DataTextField = "color";
                    ddlColor.DataValueField = "color";
                    ddlColor.DataBind();


                    ddlCombustible.DataSource = mt.Combustible();
                    ddlCombustible.DataTextField = "combustible";
                    ddlCombustible.DataValueField = "combustible";
                    ddlCombustible.DataBind();


                    ddlTipo.DataSource = mt.Tipo();
                    ddlTipo.DataTextField = "tipo";
                    ddlTipo.DataValueField = "tipo";
                    ddlTipo.DataBind();



                }




            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar los datos" + ex.Message);
                lblMensajeError.Visible = true;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                string placa = txtModificar.Value.ToString();
                string modelo = ddlModelo.SelectedValue.ToString();
                string marca = ddlMarca.SelectedValue.ToString();
                string annio = txtAnnio.Value.ToString();
                string estado = ddlEstado.SelectedValue.ToString();
                string color = ddlColor.SelectedValue.ToString();
                string combustible = ddlCombustible.SelectedValue.ToString();
                float costo = float.Parse(txtCosto.Value.ToString());
                string tipo = ddlTipo.SelectedValue.ToString();

                if (estado == "Seleccione..." || combustible == "Seleccione..." || tipo == "Seleccione...")
                {
                    lblMensajeError.Visible = true;
                }
                else
                {
                    mt.modificar(placa, modelo, marca, annio, estado, color, combustible, costo, tipo);
                    lblExito.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar los datos" + ex.Message);
                lblMensajeError.Visible = true;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionSQL mt = new ConexionSQL();
            string modificar = txtModificar.Value.ToString();
            Boolean rev;


            rev = mt.verificarVehiculo(modificar);

            if (rev == false)
            {
                lblMensajeError.Visible = true;
            }
            else
            {


                lblTipo.Visible = true;
                lblModelo.Visible = true;
                lblMarca.Visible = true;
                lblAnnio.Visible = true;
                lblColor.Visible = true;
                lblEstado.Visible = true;
                lblCosto.Visible = true;
                lblCombustible.Visible = true;

                ddlModelo.Visible = true;
                ddlMarca.Visible = true;
                txtAnnio.Visible = true;
                ddlColor.Visible = true;
                txtCosto.Visible = true;
                ddlCombustible.Visible = true;
                ddlEstado.Visible = true;
                ddlTipo.Visible = true;
                bloque.Visible = true;
                titulo.Visible = true;

                btnModificar.Visible = true;
            }
        }
    }
}