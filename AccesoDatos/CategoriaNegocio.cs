using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCaterogia()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                accesoDatos.ejecutarLectura();

                foreach (var item in accesoDatos.Lector)
                {
                    Categoria categoria = new Categoria();

                    categoria.Id = (int)accesoDatos.Lector["Id"];
                    categoria.Descripcion = (String)accesoDatos.Lector["Descripcion"];

                    listaCategoria.Add(categoria);
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

            return listaCategoria;

        }

    }
}
