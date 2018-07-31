using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
    class CReserva
    {

        private static CReserva instancia;
        private List<Reserva> reservas = new List<Reserva>();


        public static CReserva Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CReserva();
                }
                return instancia;
            }
        }
        private CReserva()
        {

        }

        public List<Menu> Menus()
        {


            return CMenu.Instancia.Menus;

        }




        #region Metodos

        public string AltaReserva(string nombreCliente, int cantPersonas, DateTime fechayhora, int  nromesa, List<Menu> listaMenus)
        {
            string mensaje = "";
            if (nombreCliente != "" && cantPersonas > 0 && fechayhora > DateTime.MinValue && nromesa>0)
            {
                Reserva r = BuscarReserva(nombreCliente);
                Mesa mesa = CMesa.Instancia.BuscarMesa(nromesa);
                if (r == null)
                {
                    if (cantPersonas > listaMenus.Count)
                    {
                        if (mesa.Capacidad > cantPersonas)
                        {
                            r = new Reserva(nombreCliente, cantPersonas, fechayhora, mesa, listaMenus);
                            reservas.Add(r);
                            mensaje = "La reserva fue agendada";
                        }else
                        {
                            mensaje = "La capacidad de la mesa no es suficiente";
                        }
                        
                    }
                    else
                    {
                        mensaje = "Se ingresaron mas menus que personas";
                    }

                }else
                {
                    mensaje = "La reserva ya existe";
                }
            }else
            {
                mensaje = "Revise lo datos ingresados";
            }
                
            

          

            return mensaje;
        }
        public string BajaReserva(string nombreCliente)
        {
            string mensaje = "";
            if (nombreCliente != "")
            {
                Reserva r = BuscarReserva(nombreCliente);
                if (r != null)
                {

                    reservas.Remove(r);
                    mensaje = "Se cancelo la reserva";

                }
                else
                {
                    mensaje = "La reserva no existe";
                }
            }
            else
            {
                mensaje = "No se igreso el nombre del cliente";

            }

            return mensaje;
        }


      



        public Menu BuscarMenuReservas(Menu m)
        {
            int i = 0;
            Menu menu = null;
            while (i < reservas.Count && menu == null)
            {
                menu = reservas[i].DevolverMenuEnReserva(m);
                i++;
            }
            return menu;
        }

        public Reserva BuscarMesaReserva(Mesa m)
        {
            int i = 0;
            Reserva re = null;
            while (i < reservas.Count && re == null)
            {
                if (reservas[i].Mesa == m)
                {
                    re = reservas[i];
                    
                }
                i++;

            }
            return re;
        }


        public Reserva BuscarReserva(string nombreCliente)
        {
            int i = 0;
            Reserva r = null;
            while (i < reservas.Count && r == null)
            {
                if (reservas[i].NombreCliente == nombreCliente)
                {
                    r = reservas[i];
                }
                i++;
            }
            return r;
        }




        public List<Reserva> MostrarReservaFecha( DateTime fecha)
        {
            List<Reserva> reservasFecha = new List<Reserva>();

            foreach (Reserva r in reservas)
            {
                if (r.Fecha.Equals(fecha))
                {

                    reservasFecha.Add(r);

                }


            }

            reservasFecha.Sort();



            return reservasFecha;
        }




        public List<Menu> MenuMasReservado()
        {

            List<Menu> menusMasReservados = new List<Menu>();
            int mayor = int.MinValue;

            foreach (Menu m in Menus())
            {
                int cantMenus = 0;
                foreach(Reserva r in reservas)
                {
                    if (r.BuscarMenu(m))
                    {
                        cantMenus++;

                    }


                }

                if(cantMenus > mayor)
                {
                    mayor = cantMenus;
                    menusMasReservados.Clear();
                    menusMasReservados.Add(m);
                }

                else if (cantMenus == mayor)
                {

                    menusMasReservados.Add(m);

                }


            }

            
            return menusMasReservados;
        }







    }
    #endregion

}
