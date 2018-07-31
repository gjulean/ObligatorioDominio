using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class Reserva : IComparable<Reserva>
    {

        #region Atributos

        private string nombreCliente;
        private int cantidad;
        private DateTime fechayhora;
        private  List<Menu> menus = new List<Menu>();
        private Mesa mesa;


        #endregion

        #region Propiedades

        public DateTime Fecha
        {

            get
            {

                return this.fechayhora;

            }


        }



        public string NombreCliente
        {
            get
            {
                return this.nombreCliente;
            }
        }
        public List<Menu> Menus
        {
            get
            {
                return this.menus;
            }
        }

        public Mesa Mesa
        {
            get
            {
                return this.mesa;
            }
        }

        public int Cantidad
        {

            get
            {

                return this.cantidad;

            }

        }



        #endregion

        #region Constructor
        public Reserva(string nombreCliente,int  cantPersonas, DateTime fechayhora,Mesa mesa, List<Menu> listaMenus)
        {
            this.nombreCliente = nombreCliente;
            this.cantidad = cantPersonas;
            this.fechayhora = fechayhora;
            this.mesa = mesa;
            this.menus = listaMenus;
        }
        #endregion



        #region Metodos

        //metodo para buscar menu en reserva con fecha de hoy para luego eliminarlo
        public Menu  DevolverMenuEnReserva(Menu me)
        {
            int i = 0;
            Menu m = null;
            while (i < menus.Count && me == null)
            {
                if (menus[i].Equals(me) && this.fechayhora>DateTime.Now)
                {
                    m = menus[i];
                }i++;
            }

            return m;
        }
        


        public bool BuscarMenu(Menu m)
        {
            bool encuentra = false;
            int i = 0;


            while(i<menus.Count && !encuentra)
            {
                if (menus[i].Equals(m))
                {

                    encuentra = true;


                }
                i++;

            }

            return encuentra;

        }





        public int CompareTo(Reserva r)
        {
            return r.cantidad.CompareTo(this.Cantidad);

            

        }


       
        #endregion

    }
}
