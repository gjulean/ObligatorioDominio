using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class Mesa
    {

        #region Atributos

        private int numero;

        private int capacidad;
        private string ubicacion;

        #endregion


        #region Constructor

        public Mesa(int numero, int capacidad, string ubicacion)
        {
            this.numero = numero;
            this.capacidad = capacidad;
            this.ubicacion = ubicacion;

        }



        #endregion

        #region Propiedades

        public int Numero
        {

            get
            {

                return this.numero;
            }
            set
            {
                this.numero = value;
            }


        }
        public int Capacidad
        {

            get
            {

                return this.capacidad;
            }
            set
            {
                this.capacidad = value;
            }


        }
        public string Ubicaicon
        {

            get
            {

                return this.ubicacion;
            }
            set
            {
                this.ubicacion = value;
            }


        }


        //pruebaGit
        #endregion

    }
}
