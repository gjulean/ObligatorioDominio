using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class CIngrediente
    {


        private static CIngrediente instancia;
        private List<Ingrediente> ingredientes = new List<Ingrediente>();


        public static CIngrediente Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CIngrediente();
                }
                return instancia;
            }
        }
        private CIngrediente()
        {

        }



        #region Metodos
        public void CargarDatosPruebaIngrediente(string[] datos)
        {
            int codigo = 0;
            int.TryParse(datos[0], out codigo);
            string descripcion = datos[1];
            int precio = 0;
            int.TryParse(datos[2], out precio);
            

            this.AltaIngrediente(codigo,descripcion,precio);

        }


        public List<Ingrediente> Ingredientes()
        {

            return this.ingredientes;


        }




        public Ingrediente BuscarIngrediente(int codigo)
        {

            int i = 0;
            Ingrediente ing = null;

            while (i < ingredientes.Count && ing == null)
            {
                if (ingredientes[i].Codigo == codigo)
                {

                    ing = ingredientes[i];


                }
                i++;
            }

            return ing;
        }



        public string AltaIngrediente(int codigo, string descripcion, decimal precio )
        {
            string mensaje = "";
            if (codigo >= 0 && descripcion != "" && precio > 0)
            {
                Ingrediente ing = BuscarIngrediente(codigo);

                if (ing == null)
                {

                    ing = new Ingrediente(codigo, descripcion, precio);
                    ingredientes.Add(ing);
                    mensaje = "Se ingreso el ingrediente correctamente";


                }else
                {
                    mensaje = "El ingrediente ya existe";
                }
            }else
            {
                mensaje = "Verifique que los datos ingresados sean correctos";

            }
            


            return mensaje;
        }
        public string BajaIngrediente(int  codigo)
        {
            string mensaje = "";
            if (codigo >=0)
            {
                Ingrediente i = BuscarIngrediente(codigo);
                if (i != null)
                {

                    ingredientes.Remove(i);
                    mensaje = "Se removio el ingrediente";

                }
                else
                {
                    mensaje = "El ingrediente no existe";
                }
            }
            else
            {
                mensaje = "No se igreso el codigo del ingrediente";

            }

            return mensaje;
        }


        public string ModificarIngrediente(int codigo, string descripcion, decimal precio)
        {
            string mensaje = "";
            if (codigo >= 0)
            {
                Ingrediente i = BuscarIngrediente(codigo);
                if (i != null)
                {
                    if (descripcion != i.Descripcion)
                    {
                       i.Descripcion = descripcion;
                        mensaje = "Se cambio la descripcion del ingrediente a: " + descripcion;


                    }

                    if( precio != i.Precio )
                    {

                        i.Precio = precio;
                        mensaje = "Se cambio el precio del ingrediente a: " + precio;
                    }



                }

                else
                {

                    mensaje = "El ingrediente no existe";
                }



            }

            else
            {

                mensaje = "El codigo tiene que ser un numero mayor a 0";

            }



            return mensaje;
        }





        #endregion

    }
}
