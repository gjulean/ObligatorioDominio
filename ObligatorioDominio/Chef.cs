using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class Chef
    {

       
        #region Atributos
        private string documento;
        private TipoDocumento tipoDocumento;
        private string primerNombre;
        private string primerApellido;
        private DateTime fechaIngreso;
        private decimal sueldo;
        #endregion


        #region Constructor

        public Chef(string documento, /*TipoDocumento tipoDocumento, */string primerNombre, string primerApellido,
            DateTime fechaIngreso, decimal sueldo)
        {
            this.documento = documento;
            //this.tipoDocumento = tipoDocumento;
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.fechaIngreso = fechaIngreso;
            this.sueldo = sueldo;

        }

        #endregion


        #region Propiedades

        public decimal Sueldo
        {

            get
            {

                return this.sueldo;

            }


        }


        public string Documento
        {

            get
            {

                return this.documento;

            }


        }




        #endregion

        #region
        public decimal CalcularSueldoHora()
        {
           return (this.sueldo / 30 )/ 8;
        }
        #endregion
    }
}
