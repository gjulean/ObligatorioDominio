using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObligatorioWeb
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {






            {
                MenuAdministrador.Visible = false;
                MenuCheff.Visible = false;
                
                switch (Session["rol"].ToString())
                {
                    case "Administrador":
                        MenuAdministrador.Visible = true; ;
                        break;

                    case "Cheff":
                        MenuCheff.Visible = true;
                        break;
                    


                    default:
                        Response.Redirect("Login.aspx");

                        break;
                }

            }


        }

        protected void BtnCerrarsesion_Click(object sender, EventArgs e)
        {
            
        }
    }
}