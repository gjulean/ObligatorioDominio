using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioAplicacion;

namespace ObligatorioWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            





        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            string rol = Fachada.Instancia.DevolverRolFachada(Login1.UserName, Login1.Password);


            if (rol != "")
            {
                e.Authenticated = true;


                Session["rol"] = rol;

                Session["nombreUsuario"] = Login1.UserName;
                if (Session["rol"].ToString() == "Administrador")
                {

                    Response.Redirect("MenusConPrecio.aspx");
                }
                if (Session["rol"].ToString() == "Cheff")
                {

                    Response.Redirect("ModificarIngredientes.aspx");
                }

            }
            else
            {
                e.Authenticated = false;
                Response.Write("Error al loguear");
                //Response.Redirect("Logix.aspx");
            }





        }
    }
}