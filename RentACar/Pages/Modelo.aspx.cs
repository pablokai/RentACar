using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class Modelo : System.Web.UI.Page
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


                ddlModelo.DataSource = ms.Modelo();
                ddlModelo.DataTextField = "modelo";
                ddlModelo.DataValueField = "modelo";
                ddlModelo.DataBind();

                titulo.Visible = false;
                txtModificar.Visible = false;
                btnActualizar.Visible = false;
            }

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

               string modelo = txtBuscar.Value.ToString();


                    ms.insertarModelo(modelo);
                    lblSuccess.Visible = true;

                ddlModelo.DataSource = ms.Modelo();
                ddlModelo.DataTextField = "modelo";
                ddlModelo.DataValueField = "modelo";
                ddlModelo.DataBind();
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

                modificar= ddlModelo.SelectedValue.ToString();
                string nuevo = txtModificar.Value.ToString();

                ms.modificarModelo(modificar, nuevo);
                lblSuccess.Visible = true;

                ddlModelo.DataSource = ms.Modelo();
                ddlModelo.DataTextField = "modelo";
                ddlModelo.DataValueField = "modelo";
                ddlModelo.DataBind();

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

                string opcModelo = ddlModelo.SelectedValue.ToString();


                ms.eliminarModelo(opcModelo);
                lblSuccess.Visible = true;

                ddlModelo.DataSource = ms.Modelo();
                ddlModelo.DataTextField = "modelo";
                ddlModelo.DataValueField = "modelo";
                ddlModelo.DataBind();
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