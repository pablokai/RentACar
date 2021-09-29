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
    public partial class Alquiler : System.Web.UI.Page
    {

        ConexionSQL ms = new ConexionSQL();
        string placa = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

                gvVehiculos.Visible = false;
                titulo.Visible = false;
                btnAvanzar.Visible = false;
                instruccion.Visible = false;

            }
            else
            {
                lblMensajeError.Visible = false;
            }

         

        }

        protected void gvVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow r = gvVehiculos.SelectedRow;

                placa = r.Cells[1].Text;

                Session["placa"] = placa;


            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar los datos" + ex.Message);
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable dt = new DataTable();
                string modelo = ddlModelo.SelectedValue.ToString();
                string marca = ddlMarca.SelectedValue.ToString();
                string annio = ddlAnnio.SelectedValue.ToString();
                string color = ddlColor.SelectedValue.ToString();
                string combustible = ddlCombustible.SelectedValue.ToString();
                string tipo = ddlTipo.SelectedValue.ToString();
                int costo = Int32.Parse( txtCosto.Value.ToString()  );
                
                dt = ms.consultarCriterios(modelo, marca, annio, costo, color, combustible, tipo);
                gvVehiculos.DataSource = dt;
                gvVehiculos.DataBind();

                if (dt.Rows.Count == 0)
                {
                    lblMensajeError.Visible = true;
                    gvVehiculos.Visible = false;
                    titulo.Visible = false;
                    btnAvanzar.Visible = false;
                    instruccion.Visible = false;
                }
                else
                {
                    lblMensajeError.Visible = false;
                    gvVehiculos.Visible = true;
                    titulo.Visible = true;
                    btnAvanzar.Visible = true;
                    instruccion.Visible = true;
                }


                   
                   
                   


            }
            catch (Exception ex)
            {
                //throw new Exception("Error al cargar los datos" + ex.Message);
               lblMensajeError.Visible = true;
            }
        }

        protected void btnAvanzar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TramitarAlquiler.aspx", false);
        }
    }
}