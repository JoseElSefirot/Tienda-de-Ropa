using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Ropa.Clases
{
    public class Estado
    {
        public int idTEstado { get; set; }

        public int estado { get; set; }

        public string Descripcion { get; set; }

        public Estado(int idTEstado, int estado, string Descripcion) 
        {
            this.idTEstado = idTEstado;
            this.estado = estado;
            this.Descripcion = Descripcion;
        } 

        public string toString()
        {
            return this.estado + " - " + this.Descripcion;
        }
    }
}
