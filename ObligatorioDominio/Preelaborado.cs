using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class Preelaborado: Menu
    {


        #region Atributos
        private string nombreProveedor;
        private decimal precio;
        private decimal porcentaje;
        #endregion



        #region Constructor

        public Preelaborado(string descripcion, string nombreProveedor, decimal precio, decimal porcentaje, decimal porcentajeMenu):base(descripcion, porcentaje)
        {

            this.nombreProveedor = nombreProveedor;
            this.precio = CalcularPrecio();
            this.porcentaje = porcentaje;

        }



        #endregion


        #region Metodos

        public override decimal CalcularPrecio()
        {

            

            decimal precio = 0;

            precio = this.precio + ((this.porcentaje * 100) / this.precio);



            return precio;
        }


        public override bool ObtenerIngrediente(Ingrediente i)
        {
            bool tiene = false;

            return tiene;

        }




        #endregion

    }
}
