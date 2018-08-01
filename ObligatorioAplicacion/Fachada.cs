using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioDominio;

namespace ObligatorioAplicacion
{


    //Prueba Git 1/8 19.11 ort
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

        public List<Reserva> MostrarReservaFechaFachada(DateTime fecha)
        {
            List<Reserva> reservasFecha = new List<Reserva>();

            if (fecha>DateTime.MinValue)
            {

                reservasFecha.AddRange(CReserva.Instancia.MostrarReservaFecha(fecha));


            }




            return reservasFecha;
        }



        public List<Menu> MostrarMenusIngredienteFachada(int id)
        {
            Ingrediente ing = CIngrediente.Instancia.BuscarIngrediente(id);
            List<Menu> menusIngrediente = new List<Menu>();

            if (ing != null)
            {

                menusIngrediente.AddRange(CMenu.Instancia.MostrarMenusIngrediente(ing));


            }

            return menusIngrediente;
        }





        public string MostraMenuConPreciosFachada()
        {


            return CMenu.Instancia.MostraMenuConPrecios();



        }



        public string CancelarReservaFachada(string nombreCliente)
        {
            string mensaje = "";

            if (nombreCliente != null)
            {

                mensaje = CReserva.Instancia.BajaReserva(nombreCliente);


            }

            return mensaje;
        }



        #endregion



    }
}
