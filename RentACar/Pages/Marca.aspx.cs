using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class Marca : System.Web.UI.Page
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


                ddlMarca.DataSource = ms.Marca();
                ddlMarca.DataTextField = "marca";
                ddlMarca.DataValueField = "marca";
                ddlMarca.DataBind();

                titulo.Visible = false;
                txtModificar.Visible = false;
                btnActualizar.Visible = false;
            }
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                string marca = txtBuscar.Value.ToString();


                ms.insertarMarca(marca);
                lblSuccess.Visible = true;

                ddlMarca.DataSource = ms.Marca();
                ddlMarca.DataTextField = "marca";
                ddlMarca.DataValueField = "marca";
                ddlMarca.DataBind();

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

                string opcMarca = ddlMarca.SelectedValue.ToString();


                ms.eliminarMarca(opcMarca);
                lblSuccess.Visible = true;

                ddlMarca.DataSource = ms.Marca();
                ddlMarca.DataTextField = "marca";
                ddlMarca.DataValueField = "marca";
                ddlMarca.DataBind();

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

                modificar = ddlMarca.SelectedValue.ToString();
                string nuevo = txtModificar.Value.ToString();

                ms.modificarMarca(modificar, nuevo);
                lblSuccess.Visible = true;

                ddlMarca.DataSource = ms.Marca();
                ddlMarca.DataTextField = "marca";
                ddlMarca.DataValueField = "marca";
                ddlMarca.DataBind();


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