using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class Color : System.Web.UI.Page
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


                ddlColor.DataSource = ms.Color();
                ddlColor.DataTextField = "color";
                ddlColor.DataValueField = "color";
                ddlColor.DataBind();

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

                string opcColor= ddlColor.SelectedValue.ToString();


                ms.eliminarColor(opcColor);
                lblSuccess.Visible = true;

                ddlColor.DataSource = ms.Color();
                ddlColor.DataTextField = "color";
                ddlColor.DataValueField = "color";
                ddlColor.DataBind();

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

                modificar = ddlColor.SelectedValue.ToString();
                string nuevo = txtModificar.Value.ToString();

                ms.modificarColor(modificar, nuevo);
                lblSuccess.Visible = true;

                ddlColor.DataSource = ms.Color();
                ddlColor.DataTextField = "color";
                ddlColor.DataValueField = "color";
                ddlColor.DataBind();


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

                string color = txtBuscar.Value.ToString();


                ms.insertarColor(color);
                lblSuccess.Visible = true;

                ddlColor.DataSource = ms.Color();
                ddlColor.DataTextField = "color";
                ddlColor.DataValueField = "color";
                ddlColor.DataBind();

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