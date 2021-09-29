using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class MontoRecaudado : System.Web.UI.Page
    {

        ConexionSQL ms = new ConexionSQL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Response.Redirect("Logon.aspx");
                }

                lblMensajeError.Visible = false;
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            

            try
            {
                string fecha = txtFecha.Value.ToString();

                int monto = ms.consultarRecaudado(fecha);

                if (monto == 0)
                {
                   
                }
                else
                {
                    contador.Visible = true;
                    num.Text = monto.ToString();
                    btnCalcular.Visible = true;
                }

            }
            catch (Exception ex)
            {

                lblMensajeError.Visible = true;
            }


        }
    }
}