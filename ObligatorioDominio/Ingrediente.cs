using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class Ingrediente
    {


        #region Atributos
        private int codigo;
        private string descripcion;
        private decimal precio;
        #endregion

        #region Constructor

        public Ingrediente(int codigo, string descripcion, decimal precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
        }



        #endregion



        #region Propiedades

        public int Codigo
        {


            get
            {

                return this.codigo;

            }


        }

        public string Descripcion
        {


            get
            {

                return this.descripcion;

            }

            set
            {

                this.Descripcion = value;

            }


        }

        public decimal Precio
        {


            get
            {

                return this.precio;

            }


            set
            {

                this.precio = value;

            }

        }




        #endregion

    }
}
