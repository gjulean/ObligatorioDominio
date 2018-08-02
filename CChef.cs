using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class CChef
    {

        private static CChef instancia;
        private List<Chef> chefs = new List<Chef>();


        public static CChef Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CChef();
                }
                return instancia;
            }
        }
        private CChef()
        {

        }

        #region Metodos

        public string AltaChef(string documento, string primerNombre, string primerApellido, DateTime fechaIngreso, decimal sueldo)
        {
            string mensaje = "";
            Chef c = BuscarChef(documento);


            if (c == null)
            {

                c = new Chef(documento, primerNombre, primerApellido, fechaIngreso, sueldo);
                mensaje = "El chef " + primerNombre + " " + primerApellido + "se dio de alta correctamente";

            }

            else
            {

                mensaje = "El chef ya existe";
            }





            return mensaje;
        }



        public Chef BuscarChef(string documento)
        {
            int i = 0;
            Chef c = null;

            while (i<chefs.Count && c==null)
            {
              if(chefs[i].Documento == documento)
                {

                    c = chefs[i];

                }
                i++;



            }

            

            return c;
        }




        #endregion


    }
}
