using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class DetallesAlquiler : System.Web.UI.Page
    {
        static string placa = null;
        static string id = null;
        static string idseguro = null;

        ConexionSQL ms = new ConexionSQL();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["placa"] == null || Session["id"] == null)
                {
                    Response.Redirect("TramitarAlquiler.aspx");
                }
                else
                {
                    placa = Session["placa"].ToString();
                    id = Session["id"].ToString();
                    titulo.Visible = false;
                    bloque.Visible = false;
                    txtMonto.Visible = false;
                    ddlPerdida.Visible = false;
                    ddlGasto.Visible = false;
                    btnAgregar.Visible = false;
                }
            }

        }

        protected void btnFormalizar_Click(object sender, EventArgs e)
        {

            try
            {
                string salida = txtSalida.Value.ToString();
                string entrega = txtEntrega.Value.ToString();
                Boolean verificarSeguro = ms.verificarSeguro(id);


                if(verificarSeguro == true)
                {
                    ms.agregarAlquiler(id, placa, salida, entrega, true);
                }
                else
                {
                    ms.agregarAlquiler(id, placa, salida, entrega, false);
                }
               

                Session.Remove("placa");
                Session.Remove("id");
                lblMensajeError.Visible = false;
                lblExito.Visible = true;
            }
            catch (Exception ex)
            {

                lblMensajeError.Visible = true;
                lblExito.Visible = false;
            }
            
        }

        protected void btnSeguro_Click(object sender, EventArgs e)
        {
            try
            {
                titulo.Visible = true;
                bloque.Visible = true;
                txtMonto.Visible = true;
                ddlPerdida.Visible = true;
                ddlGasto.Visible = true;
                btnAgregar.Visible = true;
                
                

            }
            catch (Exception ex)
            {

                lblMensajeError.Visible = true;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                string montoseguro = txtMonto.Value.ToString();
                string perdidatotal = ddlPerdida.SelectedValue.ToString();
                string gastoocupante = ddlGasto.SelectedValue.ToString();

                if(perdidatotal == "Si")
                {
                    perdidatotal = "S";
                }
                else
                {
                    perdidatotal = "N";
                }

                if (gastoocupante == "Si")
                {
                    gastoocupante = "S";
                }
                else
                {
                    gastoocupante = "N";
                }


                ms.agregarSeguro(montoseguro, perdidatotal, gastoocupante, id);


                lblError2.Visible = false;
                lblExito2.Visible = true;

            }
            catch (Exception ex)
            {

                lblError2.Visible = true;
                lblExito2.Visible = false;
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserPage.aspx", false);
        }
    }
}