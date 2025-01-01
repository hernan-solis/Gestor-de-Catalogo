using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MarcaNegocio
    {
        public List<Marca> listarMarca() 
        {
            List<Marca> listaMarca = new List<Marca>();
            AccesoDatos accesoDatos = new AccesoDatos();

            accesoDatos.setearConsulta("select Id, Descripcion from MARCAS");


            try
            {
                accesoDatos.ejecutarLectura();

                foreach (var item in accesoDatos.Lector)
                {
                    Marca marca = new Marca();

                    marca.Id = (int)accesoDatos.Lector ["Id"];
                    marca.Descripcion = (string)accesoDatos.Lector ["Descripcion"];

                    listaMarca.Add(marca);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                accesoDatos.cerrarConexion(); 
            }

       

            return listaMarca;
        }     

    }
}
