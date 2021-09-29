using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class TramitarAlquiler : System.Web.UI.Page
    {

        ConexionSQL ms = new ConexionSQL();
        static string placa = null;
        static string  idcliente = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["placa"] == null)
                {
                    Response.Redirect("Alquiler.aspx");
                }
                else
                {
                    placa = Session["placa"].ToString();
                    //Session.Remove("placa");

                    btnAvanzar.Visible = false;

                    txtCedula.Visible = false;
                    txtNombre.Visible = false;
                    txtPrimer.Visible = false;
                    txtSegundo.Visible = false;
                    txtResidencia.Visible = false;
                    txtFecha.Visible = false;
                    txtDireccion.Visible = false;
                    txtExpiracion.Visible = false;
                    txtNumTarjeta.Visible = false;

                    bloque.Visible = false;
                    titulo.Visible = false;

                    lblMensajeError.Visible = false;
                    lblExito.Visible = false;
                    LblError2.Visible = false;
                    lblExito2.Visible = false;
                    
                    
                }


            }
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                idcliente = txtBuscarID.Value.ToString();
                Boolean verificar = ms.verificarCliente(idcliente);

                if(verificar == true)
                {
                    
                    lblExito.Visible = true;
                    lblMensajeError.Visible = false;
                    btnAvanzar.Visible = true;
                    Session["id"] = idcliente;
                }
                else
                {
                    lblMensajeError.Visible = true;
                    lblExito.Visible = false;
                }



            }
            catch (Exception ex)
            {

                lblMensajeError.Visible = true;
            }
        }

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            
            try
            {
                titulo.Visible = true;
                bloque.Visible = true;
                txtCedula.Visible = true;
                txtNombre.Visible = true;
                txtPrimer.Visible = true;
                txtSegundo.Visible = true;
                txtResidencia.Visible = true;
                txtFecha.Visible = true;
                txtDireccion.Visible = true;
                txtExpiracion.Visible = true;
                txtNumTarjeta.Visible = true;

            }
            catch (Exception ex)
            {
                lblMensajeError.Visible = true;
            }
        }

        protected void btnAvanzar_Click(object sender, EventArgs e)
        {
            Session["id"] = idcliente;
            Session["placa"] = placa;
            Response.Redirect("DetallesAlquiler.aspx", false);
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtCedula.Value.ToString();
                string nombre = txtNombre.Value.ToString();
                string primerapellido = txtPrimer.Value.ToString();
                string segundoapellido = txtSegundo.Value.ToString();
                string fecha = txtFecha.Value.ToString();
                string residencia = txtResidencia.Value.ToString();
                string direccion = txtDireccion.Value.ToString();
                string tipo = ddlTipo.SelectedValue.ToString();
                string numtarjeta = txtNumTarjeta.Value.ToString();
                string fechaexp = txtExpiracion.Value.ToString();
                string tipotarjeta = ddlTipoTarjeta.SelectedValue.ToString();

                ms.agregarCliente(id, nombre, primerapellido, segundoapellido, fecha, residencia, direccion, tipo);
                ms.agregarTarjeta(numtarjeta, fecha, tipotarjeta, id);

                lblExito2.Visible = true;
                btnAvanzar.Visible = true;
                LblError2.Visible = false;

                 idcliente = id;
   


            }
            catch (Exception ex)
            {

                LblError2.Visible = true;
                lblExito2.Visible = false;
            }
        }
    }
}