using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class Usuario
    {


        #region Atributos
        private string nombreUsuario;
        private string clave;
        private string tipo;
        #endregion


        #region Constructor

        public Usuario(string nombreUsuario, string clave, string tipo)
        {
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.tipo = tipo;

        }

        #endregion

        #region Propiedades

        public string NombreUsuario
        {

            get
            {

                return this.NombreUsuario;

            }


        }

        public string Clave
        {

            get
            {

                return this.clave;

            }


        }

        public string Tipo
        {

            get
            {

                return this.tipo;

            }


        }



        #endregion


    }
}
