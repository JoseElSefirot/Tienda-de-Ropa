using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    public class Conexion
    {
        string db;
        string servidor;
        string usuario;
        string contrasena;
        string ssl;

        public Conexion()
        {
            this.db = "tienda_de_ropa";
            this.servidor = "localhost";
            this.usuario = "root";
            this.contrasena = "Sefiromaru08";
            this.ssl = "None";
        }

        public MySqlConnection ObtenerConexion() 
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = "Database=" + db +
                    "; Data Source=" + servidor +
                    ";User Id=" + usuario +
                    "; Password=" + contrasena +
                    "; SSL Mode=" + ssl + ";";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }
    }
}
