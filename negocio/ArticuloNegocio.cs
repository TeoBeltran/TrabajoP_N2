using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion as Marca, C.Descripcion as Categoria From ARTICULOS A, MARCAS M, CATEGORIAS C Where A.IdMarca=M.Id AND A.IdCategoria = C.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IdMarca = new Marca();
                    aux.IdMarca.Descripcion = (string)lector["Marca"];
                    aux.IdCategoria = new Categoria();
                    aux.IdCategoria.Descripcion = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos=new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (" + nuevo.Codigo + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @IdMarca, @IdCategoria, '" + nuevo.Precio + "')");
                datos.setearParametro("@IdMarca", nuevo.IdMarca.Id);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria.Id);
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

        public Articulo BuscarPorCodigo(string codigo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector = null;
            Articulo articulo = null;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Codigo = @Codigo";
                comando.Parameters.AddWithValue("@Codigo", codigo);
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    articulo = new Articulo();
                    articulo.Id = (int)lector["Id"];
                    articulo.Codigo = (string)lector["Codigo"];
                    articulo.Nombre = (string)lector["Nombre"];
                    articulo.Descripcion = (string)lector["Descripcion"];
                    articulo.IdMarca = new Marca();
                    articulo.IdMarca.Descripcion = (string)lector["Marca"];
                    articulo.IdCategoria = new Categoria();
                    articulo.IdCategoria.Descripcion = (string)lector["Categoria"];
                    articulo.Precio = (decimal)lector["Precio"];
                }

                return articulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (lector != null)
                {
                    lector.Close();
                }
                conexion.Close();
            }
        }

        public void Modificar(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "UPDATE ARTICULOS SET Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Codigo = @Codigo";
                comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulo.IdMarca.Id);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.IdCategoria.Id);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);
                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}