using Dominio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Id IdMarca, M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id");
                accesoDatos.ejecutarLectura();

                foreach (var item in accesoDatos.Lector)
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.Codigo = (String)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (String)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (String)accesoDatos.Lector["Descripcion"];
                    articulo.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    articulo.Marca.Descripcion = (String)accesoDatos.Lector["Marca"];
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (String)accesoDatos.Lector["Categoria"];
                    articulo.ImagenUrl = (String)accesoDatos.Lector["ImagenUrl"];
                    articulo.Precio = Convert.ToSingle(accesoDatos.Lector["Precio"]);

                    listaArticulos.Add(articulo);
                }


                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }




        }

        public void agregarArticulo(Articulo articulo) 
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            


            try
            {
                accesoDatos.setearConsulta("insert into ARTICULOS values(@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio);");
                accesoDatos.setearParametros("Codigo", articulo.Codigo);
                accesoDatos.setearParametros("Nombre", articulo.Nombre);
                accesoDatos.setearParametros("Descripcion", articulo.Descripcion);
                accesoDatos.setearParametros("IdMarca", articulo.Marca.Id.ToString());
                accesoDatos.setearParametros("IdCategoria", articulo.Categoria.Id.ToString());
                accesoDatos.setearParametros("ImagenUrl", articulo.ImagenUrl);
                accesoDatos.setearParametros("Precio", articulo.Precio.ToString(CultureInfo.InvariantCulture));

                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                accesoDatos.cerrarConexion();
            }


        }

        public void modificarArticulo(Articulo articulo) 
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id;");
               
                accesoDatos.setearParametros("Id", articulo.Id.ToString());
                accesoDatos.setearParametros("Codigo", articulo.Codigo);
                accesoDatos.setearParametros("Nombre", articulo.Nombre);
                accesoDatos.setearParametros("Descripcion", articulo.Descripcion);
                accesoDatos.setearParametros("IdMarca", articulo.Marca.Id.ToString());
                accesoDatos.setearParametros("IdCategoria", articulo.Categoria.Id.ToString());
                accesoDatos.setearParametros("ImagenUrl", articulo.ImagenUrl);
                accesoDatos.setearParametros("Precio", articulo.Precio.ToString(CultureInfo.InvariantCulture));

                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }


        }

        public void eliminarArticulo(Articulo articulo) 
        {
            AccesoDatos accesoDatos = new AccesoDatos();




            try
            {
                accesoDatos.setearConsulta("delete from ARTICULOS where Id = @Id;");
                accesoDatos.setearParametros("Id", articulo.Id.ToString());



                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                accesoDatos.cerrarConexion();
            }
        
        }
    }

}
