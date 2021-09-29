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
    public partial class RegresarVehiculo : System.Web.UI.Page
    {


        ConexionSQL ms = new ConexionSQL();
        static string idcliente = null;
        static string idalquiler = null;
        static DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                titulo.Visible = false;
                instruccion.Visible = false;
                btnRegresar.Visible = false;
                gvAlquiler.Visible = false;

                LblError2.Visible = false;
                lblExito2.Visible = false;


                }
            }

        protected void gvAlquiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow r = gvAlquiler.SelectedRow;

                idalquiler = r.Cells[1].Text;

            }
            catch (Exception ex)
            {
                LblError2.Visible = true;
            }
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                idcliente = txtBuscarID.Value.ToString();
                dt = ms.consultarAlquileres(idcliente);

                if (dt.Rows.Count == 0)
                {
                    LblError2.Visible = true;
                    lblExito2.Visible = false;
                    
                }
                else
                {
                    LblError2.Visible = false;
                    lblExito2.Visible = true;

                    gvAlquiler.DataSource = dt;
                    gvAlquiler.DataBind();

                    titulo.Visible = true;
                    instruccion.Visible = true;
                    btnRegresar.Visible = true;
                    gvAlquiler.Visible = true;
                }

            }
            catch (Exception ex)
            {

                LblError2.Visible = true;
                lblExito2.Visible = false;
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {              
                ms.regresarAlquiler(idalquiler);

                if (dt.Rows.Count == 0)
                {
                    lblError.Visible = true;
                    lblExito.Visible = false;

                }
                else
                {
                    lblError.Visible = false;
                    lblExito.Visible = true;

                    gvAlquiler.DataSource = dt;
                    gvAlquiler.DataBind();
                }

            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblExito.Visible = false;
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserPage.aspx", false);
        }
    }
}