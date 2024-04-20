using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tienda_de_Ropa.Clases.clases
{
    internal class MetodosUsuario
    {
        MySqlDataReader resultado;
        DataTable tabla = new DataTable();
        MySqlConnection sqlConexion = new MySqlConnection();

        public DataTable ObtenerUsuarios()
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerUsuarios", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure; // Cambiado a StoredProcedure
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


        public List<Permiso> ObtenerPermisos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerPermisos", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read()) 
                {
                    listaPermisos.Add(
                        new Permiso(
                            resultado.GetInt32(0),
                            resultado.GetString(1)
                            )
                        );
                }
                return listaPermisos;
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

        public List<Estado> ObtenerEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ObtenerEstados", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    listaEstados.Add(
                        new Estado(
                            resultado.GetInt32(0),
                            resultado.GetInt32(1),
                            resultado.GetString(2)
                            )
                        );
                }

                return listaEstados;
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

        public string ValidarUsuario(Usuario usuario)
        {
            string resultado = null;

            if ( usuario.NomUsuario.Equals("") || usuario.usuario.Equals("") || usuario.contrasena.Equals("") || usuario.TPrmisos_idTPrmisos == 0 || usuario.TEstado_idTEstado == 0)
            {
                resultado = "Te falta llenar algo :v";
            }
            else
            {
                resultado = "OK";
            }
            return resultado;
        }

        public string AgregarUsuarios(Usuario usuario)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("InsertarUsuarios", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@NomUsuario", MySqlDbType.VarChar).Value = usuario.NomUsuario;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.usuario;
                comando.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = usuario.contrasena;
                comando.Parameters.Add("@TPrmisos_idTPrmisos", MySqlDbType.Int32).Value = usuario.TPrmisos_idTPrmisos;
                comando.Parameters.Add("@TEstado_idTEstado", MySqlDbType.Int32).Value = usuario.TEstado_idTEstado;
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

        public string ActualizarUsuario(int idTUsuarios, Usuario usuario)
        {
            string respuesta = "";

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("ActualizarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", MySqlDbType.Int32).Value = idTUsuarios;
                comando.Parameters.Add("@NomUsuario", MySqlDbType.VarChar).Value = usuario.NomUsuario;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.usuario;
                comando.Parameters.Add("@contrasena", MySqlDbType.VarChar).Value = usuario.contrasena;
                comando.Parameters.Add("@TPrmisos_idTPrmisos", MySqlDbType.Int32).Value = usuario.TPrmisos_idTPrmisos;
                comando.Parameters.Add("@TEstado_idTEstado", MySqlDbType.Int32).Value = usuario.TEstado_idTEstado;
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

        public DataTable BuscarUsuario(string nombre)
        {
            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("BuscarUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = nombre.Trim();
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

        public Usuario LoginUsuario(string usuario, string contrasena)
        {
            Usuario user = new Usuario();

            try
            {
                sqlConexion = new Conexion().ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("LoginUsuario", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@user", MySqlDbType.VarChar).Value = usuario.Trim();
                comando.Parameters.Add("@pass", MySqlDbType.VarChar).Value = contrasena.Trim();
                sqlConexion.Open();
                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    if (resultado.Equals(""))
                    {
                        user.idTUsuarios = 0;
                    }
                    else
                    {

                        user = new Usuario(
                            resultado.GetInt32(0),
                            resultado.GetString(1),
                            resultado.GetString(2),
                            resultado.GetString(3),
                            resultado.GetInt32(4),
                            resultado.GetInt32(5)
                            );
                    }
                }
                return user;
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
