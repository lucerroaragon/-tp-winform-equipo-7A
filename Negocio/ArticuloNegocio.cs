using Dominio;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarTodos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select A.Id , A.Codigo, A.Nombre, M.Descripcion Marca, C.Descripcion Categoria, A.Precio, A.Descripcion, I.ImagenUrl from ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.CodArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.marca = new Marca();
                    aux.marca.Nombre = (string)datos.Lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.Nombre = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Imagenes = new List<Imagen>();
                    if (!(datos.Lector["ImagenUrl"]is DBNull))
                    aux.Imagenes.Add(new Imagen { Url = (string)datos.Lector["ImagenUrl"] });






                    lista.Add(aux);
                
                   

            }


                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void agregar ( Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,Precio,IdMarca, IdCategoria) VALUES (@Codigo, @Nombre, @Descripcion,@Precio, @IdMarca, @IdCategoria)");
                datos.setearParametro("@Codigo", nuevo.CodArticulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdMarca", nuevo.marca.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.categoria.IdCategoria);
                

               

                datos.ejecutarAccion();
                    
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar ( Articulo modificar)
        {

        }

    }
}