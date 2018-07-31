using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatorioAplicacion;    

namespace ObligatorioWeb
{
    public partial class MostrarMenusPorIngrediente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // DDlIngredientesMenu.DataSource = 



            }





           /* DDLCancha.DataSource = Empresa.Instancia.Cancha;
            DDLCancha.DataTextField = "Numero";
            DDLCancha.DataValueField = "Numero";
            DDLCancha.DataBind();*/



        }

        protected void DDlIngredientesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {







        }
    }
}