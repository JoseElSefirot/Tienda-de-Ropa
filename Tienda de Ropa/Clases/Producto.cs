using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    internal class Producto
    {
        public string idTProducto { get; set; }
        public string NomProducto { get; set; }
        public string Stock { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set;}
        public string TProveedor_idTProveedor { get; set; }
        public string NomProveedor { get; set;}
        public int CantidadVendida { get; set; }

        public Producto(string idTProducto, string NomProducto, string Stock, string Precio, string Descripcion, string TProveedor_idTProveedor, string NomProveedor)
        {
            this.idTProducto = idTProducto;
            this.NomProducto = NomProducto;
            this.Stock = Stock;
            this.Precio = Precio;
            this.Descripcion = Descripcion;
            this.TProveedor_idTProveedor = TProveedor_idTProveedor;
            this.NomProveedor = NomProveedor;
        }

        public Producto(string idTProducto, string NomProducto, string Stock, string Precio, string Descripcion, string TProveedor_idTProveedor)
        {
            this.idTProducto = idTProducto;
            this.NomProducto = NomProducto;
            this.Stock = Stock;
            this.Precio = Precio;
            this.Descripcion = Descripcion;
            this.TProveedor_idTProveedor = TProveedor_idTProveedor;
        }

        public Producto(string idTProducto, string NomProducto, string Stock, string Precio, string Descripcion)
        {
            this.idTProducto = idTProducto;
            this.NomProducto = NomProducto;
            this.Stock = Stock;
            this.Precio = Precio;
            this.Descripcion = Descripcion;
        }

        public Producto(string idTProducto, string NomProducto, int CantidadVendida)
        {
            this.idTProducto = idTProducto;
            this.NomProducto = NomProducto;
            this.CantidadVendida = CantidadVendida;
        }


    }
}
