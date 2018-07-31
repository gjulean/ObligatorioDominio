using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class Propio : Menu
    {

        #region Atributos
        private List<IngredienteCantidad> ingredientesCantidad = new List<IngredienteCantidad>();
        private Chef chef;
        private decimal horasElavoracion;
        #endregion

        #region Constructor

        public Propio(string descripcion ,Chef chef, decimal horasElavoracion, decimal porcentaje,List<IngredienteCantidad> ingredientes) : base(descripcion, porcentaje)
        {

            this.chef = chef;
            this.horasElavoracion = horasElavoracion;
            this.ingredientesCantidad = ingredientes;


        }


        #endregion



        #region Metodos

        


        public void AgregarIngrediente(Ingrediente i , int cantidad)
        {

            this.ingredientesCantidad.Add(new IngredienteCantidad(i,cantidad));


        }



        public decimal PrecioTotalIngredientes()
        {
            decimal precio = 0;



            foreach(IngredienteCantidad ic in ingredientesCantidad)
            {

                precio += ic.CalcularPrecioIngrediente();


            }




            return precio;

        }



        public override decimal CalcularPrecio()
        {
            decimal precio = 0;

            precio = PrecioTotalIngredientes() + this.chef.CalcularSueldoHora() * this.horasElavoracion;



            return precio;
        }


        public override bool ObtenerIngrediente(Ingrediente i)
        {
            bool tiene = false;
            int j = 0;

            while(j<ingredientesCantidad.Count && !tiene)
            {
                if (ingredientesCantidad[j].Ingrediente.Equals(i))
                {

                    tiene = true;


                }
                j++;


            }




            return tiene;
        }


        #endregion


    }
}
