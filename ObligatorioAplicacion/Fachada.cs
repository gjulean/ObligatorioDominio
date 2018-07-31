using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio;

namespace ObligatorioAplicacion
{
   public class Fachada
    {

        private static Fachada instancia;

        public static Fachada Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Fachada();
                }
                return instancia;
            }
        }


       
        




        #region Metodos

        public List<Menu> MostrarMenusIngredienteFachada(Ingrediente i)
        {

            List<Menu> menusPorIngrediente = new List<Menu>();

           foreach(Menu m in CMenu.Instancia.Menus)

                if (m.ObtenerIngrediente(i))
                {

                    menusPorIngrediente.Add(m);

                }




            return menusPorIngrediente;

        }

        


        #endregion



    }
}
