using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    internal class MetodosProveedores
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerProveedores()
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerProveedores", sqlConexion);
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

        public string AgregarProveedor(Proveedor proveedor)
        {

        string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NomProveedor", MySqlDbType.VarChar).Value = proveedor.NomProveedor;
                comando.Parameters.Add("@NumContacto", MySqlDbType.VarChar).Value = proveedor.NumContacto;
                comando.Parameters.Add("@Direccion", MySqlDbType.VarChar).Value = proveedor.Direccion;
                comando.Parameters.Add("@Email", MySqlDbType.VarChar).Value = proveedor.Email;
               
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

        public DataTable BuscarProveedor(string nombre)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@proveedor", MySqlDbType.VarChar).Value = nombre.Trim();
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

        public string ActualizarProveedor(int idTProveedor, Proveedor proveedor)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarProveedor", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idTProveedor;
                comando.Parameters.Add("@NomProveedor", MySqlDbType.VarChar).Value = proveedor.NomProveedor;
                comando.Parameters.Add("@NumContacto", MySqlDbType.VarChar).Value = proveedor.NumContacto;
                comando.Parameters.Add("@Direccion", MySqlDbType.VarChar).Value = proveedor.Direccion;
                comando.Parameters.Add("@Email", MySqlDbType.VarChar).Value = proveedor.Email;
               
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

        public string ValidarProveedor(Proveedor proveedor)
        {
            string resultado = null;

            if (proveedor.NomProveedor.Equals("") || proveedor.NumContacto.Equals("") || proveedor.Direccion.Equals("") || proveedor.Email.Equals(""))
            {
                resultado = "Te falta llenar algo :v";
            }
            else
            {
                resultado = "OK";
            }
            return resultado;
        }
    }
}
