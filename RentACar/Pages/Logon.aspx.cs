using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar.Pages
{
    public partial class Logon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            string user = UserName.Text;
            string pass = UserPass.Text;

            try
            {
                ConexionSQL ms = new ConexionSQL();

                
               Boolean revisar = ms.validarUsuario(user, pass);

                if(revisar == true)
                {
                    HttpCookie cookie = new HttpCookie("Token", user);
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    this.Response.Cookies.Add(cookie);

                    Session["Login"] = user;
                    Response.Redirect("Default.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();

                }
                else
                {
                    Msg.Text = "No existe el usuario";
                    Msg.Visible = true;
                }

                


            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos" + ex.Message);
                //lblError.Visible = true;
            }


            
        }
    }
}