using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    public class Permiso
    {
        public int idTPrmisos {  get; set; }
        public string permiso { get; set; }

        public Permiso (int idTPrmisos, string permiso)
        {
            this.idTPrmisos = idTPrmisos;
            this.permiso = permiso;
        }

        public string toString()
        {
            return this.idTPrmisos + " - " + this.permiso;
        }
    }
}
