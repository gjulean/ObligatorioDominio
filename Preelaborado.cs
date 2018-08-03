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
        private static decimal porcentaje = new decimal (1.5);
        
        #endregion



        #region Constructor

        public Preelaborado(string descripcion, string nombreProveedor, decimal precio):base(descripcion)
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

        public static decimal Porcentaje
        {

            get
            {

                return porcentaje;

            }


            set
            {

                porcentaje = value;

            }

        }



        #region Metodos

        public override decimal CalcularPrecio()
        {


            return precioPreeaborado;


        }


        public override bool ObtenerIngrediente(Ingrediente i)
        {
            bool tiene = false;

            return tiene;

        }

        public override IngredienteCantidad BuscarIngredienteCantidad(Ingrediente i)
        {
            return null;
        }

        public override List<Ingrediente> ListarIngredientesCantidad()
        {
            return null;
        }

        public override bool ConfirmarPropio()
        {
            return false;
        }
        #endregion

    }

    
}
