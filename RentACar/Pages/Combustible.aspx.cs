using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class Combustible : System.Web.UI.Page
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


                ddlCombustible.DataSource = ms.Combustible();
                ddlCombustible.DataTextField = "combustible";
                ddlCombustible.DataValueField = "combustible";
                ddlCombustible.DataBind();

                titulo.Visible = false;
                txtModificar.Visible = false;
                btnActualizar.Visible = false;
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

                string opcCombustible= ddlCombustible.SelectedValue.ToString();


                ms.eliminarCombustible(opcCombustible);
                lblSuccess.Visible = true;

                ddlCombustible.DataSource = ms.Combustible();
                ddlCombustible.DataTextField = "combustible";
                ddlCombustible.DataValueField = "combustible";
                ddlCombustible.DataBind();

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

                modificar = ddlCombustible.SelectedValue.ToString();
                string nuevo = txtModificar.Value.ToString();

                ms.modificarCombustible(modificar, nuevo);
                lblSuccess.Visible = true;

                ddlCombustible.DataSource = ms.Combustible();
                ddlCombustible.DataTextField = "combustible";
                ddlCombustible.DataValueField = "combustible";
                ddlCombustible.DataBind();


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

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                string combustible = txtBuscar.Value.ToString();


                ms.insertarCombustible(combustible);
                lblSuccess.Visible = true;

                ddlCombustible.DataSource = ms.Combustible();
                ddlCombustible.DataTextField = "combustible";
                ddlCombustible.DataValueField = "combustible";
                ddlCombustible.DataBind();

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