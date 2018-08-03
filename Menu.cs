using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public abstract class Menu
    {

        #region Atributos

        private int id;
        private static int ultId;
        private string descripcion;
        private decimal precio;
        

        #endregion

        #region Propiedades
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }


        public decimal Precio
        {

            get
            {
                return this.precio;

            }

        }

       


        #endregion

        #region Constructor

        public Menu(string descripcion)
        {

            this.descripcion = descripcion;

            //se calculan, no se reciben por parametro
            this.precio = CalcularPrecio();
            
            
            this.id = Menu.ultId;
            Menu.ultId++;

        }




        #endregion


        #region Metodos

        public abstract decimal CalcularPrecio();

        public abstract bool ObtenerIngrediente(Ingrediente i);


       

        

        #endregion

        public abstract IngredienteCantidad BuscarIngredienteCantidad(Ingrediente i);
        public abstract List<Ingrediente> ListarIngredientesCantidad();
        public abstract bool ConfirmarPropio();




    }
}
