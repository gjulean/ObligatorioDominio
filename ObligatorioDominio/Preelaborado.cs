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
        private decimal precioPreeaborado;
        
        #endregion



        #region Constructor

        public Preelaborado(string descripcion, string nombreProveedor, decimal precio, decimal porcentaje):base(descripcion, porcentaje)
        {

            this.nombreProveedor = nombreProveedor;
            this.precioPreeaborado = CalcularPrecio();
           

        }



        #endregion


        #region Propiedades




        #endregion

        public string NombreProveedor
        {

            get
            {
                return this.nombreProveedor;

            }

            set
            {

                this.nombreProveedor = value;

            }

        }



        public decimal PrecioPreelaborado
        {

            get
            {

                return this.precioPreeaborado;

            }


            set
            {

                this.precioPreeaborado = value;

            }

        }



        #region Metodos

        public override decimal CalcularPrecio()
        {


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
