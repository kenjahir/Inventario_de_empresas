using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    //Clase padre Metodo de pago y cualidades.
    class Pago : IMetodos
    {
        public string id { get; set; }

        //Metodo polimorfico mostrar datos 
        public virtual void Mostrar()
        {

        }
    }
}
