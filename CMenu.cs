using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObligatorioDominio
{
   public class CMenu
    {

        private static CMenu instancia;
        private List<Menu> menus = new List<Menu>();


        public static CMenu Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new CMenu();
                }
                return instancia;
            }
        }
        private CMenu()
        {

        }

        #region Propiedades

        public List<Menu> Menus
        {

            get
            {
                return this.menus;

            }


        }


        #endregion

        #region Metodos

        public string AltaMenuPropio(string descripcion, string documento, decimal horasElavoracion, decimal porcentaje,List<IngredienteCantidad> ingredientes)
        {
            string mensaje = "";
            if (descripcion!="" &&documento!="" && horasElavoracion > 0 && porcentaje>0)
            {
                if(ingredientes.Count > 0)
                {
                    Menu m = BuscarMenu(descripcion);
                    if (m == null)
                    {
                        Chef c = CChef.Instancia.BuscarChef(documento);
                        if (c != null)
                        {
                            m = new Propio(descripcion, c, horasElavoracion, porcentaje, ingredientes);
                            menus.Add(m);
                            mensaje = "Se ingreso el menu correctamente";
                        }
                        else
                        {
                            mensaje = "No se encontro el chef";
                        }
                    }
                    else
                    {
                        mensaje = "El menu ya existe";
                    }
                }else
                {
                    mensaje = "No se ingresaron ingredientes";
                }
                
            }else
            {
                mensaje = "Los datos ingresados no son correctos";
            }
            
            







            return mensaje;
        }

        public string BajaMenu(int id)
        {
            string mensaje = "";
            if (id >=0)
            {
                Menu m = BuscarMenu(id);
                if (m != null)
                {
                    Menu menuReserva = CReserva.Instancia.BuscarMenuReservas(m);
                    if (menuReserva == null)
                    {
                        menus.Remove(m);
                        mensaje = "Se removio el menu";
                    }
                }
                else
                {
                    mensaje = "El menu no existe";
                }
            }
            else
            {
                mensaje = "No se ingreso la descripcion";

            }

            return mensaje;
        }
        public string AltaMenuPreElaborado(string descripcion, string nombreProveedor, decimal precio, decimal porcentaje, decimal porcentajeMenu)
        {
            string mensaje = "";

            Menu m = BuscarMenu(descripcion);

            if (descripcion !="" && nombreProveedor != "" && precio > 0 && porcentaje >0 && porcentajeMenu > 0)
            {

                if (m == null)
                {

                   m = new Preelaborado(descripcion, nombreProveedor, precio, porcentaje);
                    menus.Add(m);
                    mensaje = "El menu se a dado de alta";

                }


             }

            else
            {

                mensaje = "El menu ya existe";

            }







                return mensaje;
        }

        


        public Menu BuscarMenu(string descrip)
        {
            int i = 0;
            Menu m = null;

            while (i < menus.Count && m == null)
            {
                if (menus[i].Descripcion == descrip)
                {
                    m=menus[i];
                }i++;
            }



            return m;
        }

        public Menu BuscarMenu(int id)
        {
            int i = 0;
            Menu m = null;

            while (i < menus.Count && m == null)
            {
                if (menus[i].Id == id)
                {
                    m = menus[i];
                }
                i++;
            }



            return m;
        }


        public string ModificarMenuPreelaborado(int id, string descripcion, string nombreProveedor, decimal precio, decimal porcentaje)
        {
            string mensaje = "";
            Menu m = BuscarMenu(id);

            if (id > 0)
            {

                if (m != null)
                {
                    if (descripcion != m.Descripcion)
                    {
                        descripcion = m.Descripcion;
                        mensaje = "Se ha modificado la descripcion a: " + descripcion + "\n";
                    }

                    //if(nombreProveedor != m.)




                }

                else
                {

                    mensaje = "El menu no existe";
                }

            }

            else
            {

                mensaje = "El id tiene que ser un numero mayor a 0";
            }


            return mensaje;
        }



        public string MostraMenuConPrecios()
        {
           

            string menusPrecios = "";


            foreach(Menu m in menus)
            {

                menusPrecios += m.Descripcion + " " + m.Precio;

            }







            return menusPrecios;
        }



      


        public List<Menu> MostrarMenusIngrediente(Ingrediente i)
        {
            List<Menu> menusIngrediente = new List<Menu>();

            if (i != null) { 

            foreach (Menu m in menus)
            {
                if (m.ObtenerIngrediente(i))
                {

                    menusIngrediente.Add(m);

                }


            }

            }
            return menusIngrediente;
        }








        #endregion

    }
}
