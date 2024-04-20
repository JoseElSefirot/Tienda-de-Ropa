using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    internal class Proveedor
    {
        public int idTProveedor { get; set; }
        public string NomProveedor { get; set; }
        public string NumContacto { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public Proveedor(int idTProveedor, string NomProveedor) 
        {
            this.idTProveedor = idTProveedor;
            this.NomProveedor= NomProveedor;
        } 
        
        public Proveedor(int idTProveedor, string NomProveedor, string NumContacto, string Direccion, string Email)
        {
            this.idTProveedor = idTProveedor;
            this.NomProveedor = NomProveedor;
            this.NumContacto = NumContacto;
            this.Direccion = Direccion;
            this.Email = Email;
        }

        public Proveedor(string NomProveedor, string NumContacto, string Direccion, string Email)
        {
            this.NomProveedor = NomProveedor;
            this.NumContacto = NumContacto;
            this.Direccion = Direccion;
            this.Email = Email;
        }
    }
}
