using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class CMesa
    {
        private static CMesa instancia;
        private List<Mesa> mesas = new List<Mesa>();


        public static CMesa Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CMesa();
                }
                return instancia;
            }
        }
        private CMesa()
        {

        }

        #region Metodos

        public Mesa BuscarMesa(int numero)
        {

            int i = 0;
            Mesa m = null;

            while (i < mesas.Count && m == null)
            {
                if (mesas[i].Numero == numero)
                {

                    m = mesas[i];


                }
                i++;
            }

            return m;
        }


        public string AltaMesa(int numero, int capacidad, string ubicacion)
        {

            string mensaje = "";
            Mesa m = BuscarMesa(numero);

            if (m == null)
            {
                m = new Mesa(numero,capacidad,ubicacion);
                mensaje = "Se dio de alta la mesa " + numero;

            }

            else
            {
                mensaje = "La mesa ya existe";

            }


            return mensaje;

        }

        public string BajaMesa(int numero)
        {
            string mensaje = "";
            if (numero >0)
            {
                Mesa m = BuscarMesa(numero);
                Reserva re = CReserva.Instancia.BuscarMesaReserva(m);
                if (m != null)

                {
                    if (re == null)
                    {
                        mesas.Remove(m);
                        mensaje = "Se removio la mesa";
                    }
                   

                }
                else
                {
                    mensaje = "La mesa no existe";
                }
            }
            else
            {
                mensaje = "El numero de la mesa no es mayor a cero";

            }

            return mensaje;
        }

        public string ModificarMesa(int numero,int capacidad,string ubicacion)
        {
            string mensaje = "";
            if (numero > 0 && capacidad > 0 && ubicacion != "")
            {
                Mesa m = BuscarMesa(numero);
                
                if (m != null)
                {
                    if (numero != m.Numero)
                    {
                        m.Numero = numero;
                        mensaje += "Se cambio el numero de la mesa a " + numero + "<br>";
                    }
                    if (capacidad != m.Capacidad)
                    {
                        m.Capacidad = capacidad;
                        mensaje += "Se cambio la capicad  de la mesa a " + capacidad + " personas" + "<br>";
                    }
                    if (ubicacion != m.Ubicaicon)
                    {
                        m.Ubicaicon = ubicacion;
                        mensaje += "Se cambio la ubicacion de la mesa a " + ubicacion + "<br>";
                    }
                }
                else
                {
                    mensaje = "No se encontro la mesa";
                }
            }else
            {
                mensaje = "Verifique que los datos ingresados a cambiar sean correctos";
            }
            

            return mensaje;

        }







        #endregion



    }
}
