using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class Tipo : System.Web.UI.Page
    {

        ConexionSQL ms = new ConexionSQL();
        string modificar = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Response.Redirect("Logon.aspx");
                }


                ddlTipo.DataSource = ms.Tipo();
                ddlTipo.DataTextField = "tipo";
                ddlTipo.DataValueField = "tipo";
                ddlTipo.DataBind();

                titulo.Visible = false;
                txtModificar.Visible = false;
                btnActualizar.Visible = false;
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                string tipo = txtBuscar.Value.ToString();


                ms.insertarTipo(tipo);
                lblSuccess.Visible = true;

                ddlTipo.DataSource = ms.Tipo();
                ddlTipo.DataTextField = "tipo";
                ddlTipo.DataValueField = "tipo";
                ddlTipo.DataBind();

                lblExito.Visible = true;
                lblMensajeError.Visible = false;

            }
            catch (Exception ex)
            {
                //throw new Exception("Error al ingresar los datos  " + ex.Message);
                lblMensajeError.Visible = true;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                titulo.Visible = true;
                txtModificar.Visible = true;
                btnActualizar.Visible = true;
                lblMensajeError.Visible = false;

            }
            catch (Exception ex)
            {
                //throw new Exception("Error al ingresar los datos  " + ex.Message);
                lblMensajeError.Visible = true;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string opcTipo = ddlTipo.SelectedValue.ToString();


                ms.eliminarTipo(opcTipo);
                lblSuccess.Visible = true;

                ddlTipo.DataSource = ms.Tipo();
                ddlTipo.DataTextField = "tipo";
                ddlTipo.DataValueField = "tipo";
                ddlTipo.DataBind();

                lblExito.Visible = true;
                lblMensajeError.Visible = false;

            }
            catch (Exception ex)
            {
                //throw new Exception("Error al ingresar los datos  " + ex.Message);
                lblMensajeError.Visible = true;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                modificar = ddlTipo.SelectedValue.ToString();
                string nuevo = txtModificar.Value.ToString();

                ms.modificarTipo(modificar, nuevo);
                lblSuccess.Visible = true;

                ddlTipo.DataSource = ms.Tipo();
                ddlTipo.DataTextField = "tipo";
                ddlTipo.DataValueField = "tipo";
                ddlTipo.DataBind();

                titulo.Visible = false;
                txtModificar.Visible = false;
                btnActualizar.Visible = false;
                lblExito.Visible = true;
                lblMensajeError.Visible = false;

            }
            catch (Exception ex)
            {
                //throw new Exception("Error al ingresar los datos  " + ex.Message);
                lblMensajeError.Visible = true;
            }
        }
    }
}