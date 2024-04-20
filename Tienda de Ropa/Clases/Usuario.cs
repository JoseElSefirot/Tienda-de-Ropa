using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    public class Usuario
    {
        public int idTUsuarios { get; set; }
        public string NomUsuario { get; set; }
        public string usuario { get; set; }

        public string contrasena {  get; set; } 

        public int TPrmisos_idTPrmisos { get; set; }

        public int TEstado_idTEstado {  get; set; }

        public double totalVendido { get; set; }

        public Usuario() { }

        public Usuario(int idTUsuarios, string NomUsuario, string usuario, string contrasena, int tPrmisos_idTPrmisos, int tEstado_idTEstado)
        {
            this.idTUsuarios = idTUsuarios;
            this.NomUsuario = NomUsuario;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.TPrmisos_idTPrmisos = tPrmisos_idTPrmisos;
            this.TEstado_idTEstado = tEstado_idTEstado;
        }

        public Usuario(string NomUsuario, string usuario, string contrasena, int tPrmisos_idTPrmisos, int tEstado_idTEstado)
        {
            this.NomUsuario = NomUsuario;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.TPrmisos_idTPrmisos = tPrmisos_idTPrmisos;
            this.TEstado_idTEstado = tEstado_idTEstado;
        }

        public Usuario(int idTUsuarios, string NomUsuario, double totalVendido)
        {
            this.idTUsuarios = idTUsuarios;
            this.NomUsuario = NomUsuario;
            this.totalVendido = totalVendido;
        }

    }
}
