using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    internal class MetodosProductos
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();
        Producto producto;
        string NomProducto;

        public DataTable ObtenerProductos()
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProductos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public List<Proveedor> ObtenerProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaProveedores.Add(
                        new Proveedor(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                            )
                        );
                }

                return listaProveedores;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }

        }

        public string ValidarProducto(Producto producto)
        {
            string resultado = null;

            if (producto.idTProducto.Equals("") || producto.NomProducto.Equals("") || producto.Stock.Equals("") || producto.Precio.Equals("") || producto.Descripcion.Equals(""))
            {
                resultado = "Te falta llenar algo :v";
            }
            else
            {
                resultado = "OK";
            }
            return resultado;
        }

        public string AgregarProducto(Producto producto)
        {

            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProductos", sqlConexion);
                
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@idTProducto", MySqlDbType.VarChar).Value = producto.idTProducto;
                comando.Parameters.Add("@NomProducto", MySqlDbType.VarChar).Value = producto.NomProducto;
                comando.Parameters.Add("@Stock", MySqlDbType.Int32).Value = producto.Stock;
                comando.Parameters.Add("@Precio", MySqlDbType.Double).Value = producto.Precio;
                comando.Parameters.Add("@Descripcion", MySqlDbType.Text).Value = producto.Descripcion;
                comando.Parameters.Add("@TProveedor_idTProveedor", MySqlDbType.Int32).Value = producto.TProveedor_idTProveedor;

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Bien hecho se creo :p";
                }
                else
                {
                    respuesta = "No se puede pa intenta otra cosa :p";
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public string ActualizarProducto( Producto producto)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProducto", sqlConexion);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToInt32(producto.idTProducto);
                comando.Parameters.Add("@NomProducto", MySqlDbType.VarChar).Value = producto.NomProducto;
                comando.Parameters.Add("@Stock", MySqlDbType.Int32).Value = Convert.ToInt32(producto.Stock);
                comando.Parameters.Add("@Precio", MySqlDbType.Double).Value =Convert.ToDouble(producto.Precio);
                comando.Parameters.Add("@Descripcion", MySqlDbType.Text).Value = producto.Descripcion;
                comando.Parameters.Add("@TProveedor_idTProveedor", MySqlDbType.Int32).Value = Convert.ToInt32(producto.TProveedor_idTProveedor);

                sqlConexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Este wey se modifico ";
                }
                else
                {
                    respuesta = "no eres vip pa";
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public DataTable BuscarProductos(string producto)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProductos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@producto", MySqlDbType.VarChar).Value = producto.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public Producto BuscarProductoVenta(string codigo)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProductoVenta", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                
                while (resultado.Read())
                {
                    producto = new Producto(
                        resultado.GetString(0),
                        resultado.GetString(1),
                        resultado.GetString(2),
                        resultado.GetString(3),
                        resultado.GetString(4)
                        );   
                }

                return producto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }

        public string ObtenerNombreProducto(string codigo)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerNombreProducto", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codigo.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    NomProducto = resultado.GetString(0);
                }

                return NomProducto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
        }
    }
}
