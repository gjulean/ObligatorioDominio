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

        
        public string AltaReservaFachada(string nombreCliente, int cantPersonas, DateTime fechayhora, int nromesa, List<Menu> listaMenus)
        {
            string mensaje = "";
            Reserva r = CReserva.Instancia.BuscarReserva(nombreCliente);
            Mesa mesa = CMesa.Instancia.BuscarMesa(nromesa);


            if (nombreCliente != "" && cantPersonas > 0 && fechayhora > DateTime.MinValue && fechayhora > DateTime.Today && nromesa >0 &&
                cantPersonas > listaMenus.Count && mesa.Capacidad > cantPersonas)

            {

                //Por que no puedo poner el objeto mesa en el alta?
                mensaje = CReserva.Instancia.AltaReserva(nombreCliente, cantPersonas, fechayhora, nromesa, listaMenus);


            }







            return mensaje;
        }

        public List<Reserva> MostrarReservaFecha(DateTime fecha)
        {


            //if (fecha > DateTime.MinValue) { 
            return CReserva.Instancia.MostrarReservaFecha(fecha);


           // }
        }





        #endregion



    }
}
