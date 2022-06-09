using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class Producto
    {
        //Clase Padre Producto y sus cualidades
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }

        //Metodo polimorfico mostrar datos
        public Producto(string codigo, string descripcion, int existencia)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Existencia = existencia;



        }
    }
}
 