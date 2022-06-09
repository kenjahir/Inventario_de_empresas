using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    //Clase Entrega y cualidades, hereda de Equipo.
    class Entrega : Equipo, IMetodos
    {
        public string numeroentrega { get; set; }
        public string descripcionentrega { get; set; }
        public string Afirmacion { get; set; }

        //Metodo polimorfico mostrar datos  
        public void Mostrar()
        {
            Console.WriteLine("Número de entrega: " + numeroentrega + "\nDescripción: "
                + descripcionentrega + "\nAfirmacion de pedido: " + Afirmacion );
        }
    }
}
