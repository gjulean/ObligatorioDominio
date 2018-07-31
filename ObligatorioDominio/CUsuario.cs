using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioDominio
{
   public class CUsuario
    {

        private static CUsuario instancia;
        private List<Usuario> usuarios = new List<Usuario>();


        public static CUsuario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CUsuario();
                }
                return instancia;
            }
        }
        private CUsuario()
        {

        }

        public Usuario BuscarUsuario(string nombreUsuario)
        {
            int i = 0;
            Usuario u = null;
            while (i < usuarios.Count && u == null)
            {
                if (usuarios[i].NombreUsuario == nombreUsuario)
                {

                    u = usuarios[i];


                }
                i++;
            }

            return u;


        }




    }
}
