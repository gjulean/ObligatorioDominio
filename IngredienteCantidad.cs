using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class IngredienteCantidad
    {

        #region Atributos
        private Ingrediente ingrediente;
        private decimal cantidad;
        #endregion

        #region Propiedades

        public Ingrediente Ingrediente
        {

            get
            {

                return this.ingrediente;
            }

        }

        public decimal Cantidad
        {
            get
            {
                return this.cantidad;

            }

            set
            {
                this.cantidad = value;
            }
        }


        #endregion

        #region Constructor

        public IngredienteCantidad( Ingrediente ingrediente, decimal cantidad)
        {
            this.ingrediente = ingrediente;
            this.cantidad = cantidad;


        }


        #endregion


        #region Metodos

        public decimal CalcularPrecioIngrediente()
        {
            decimal precio = 0;

            precio = this.ingrediente.Precio * this.cantidad;




            return precio;
        }



        #endregion

    }
}
