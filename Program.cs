using System;

namespace inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            Inventario inventario = inventario();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de inventario");
                Console.WriteLine("****************+******");
                Console.WriteLine("");
                Console.WriteLine("1- Productos");
                Console.WriteLine("2-Ingreso de inventario");
                Console.WriteLine("3-Salida de inventario");
                Console.WriteLine("4-Ajuste Positivio de Inventario");
                Console.WriteLine("5-Ajuste Negativo de Inventario");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        inventario.listaProductos();
                        break;
                    case "2":
                        inventario.ingresoDeInventario();
                        break;
                    case "3":
                        inventario.salidaDeInventario();
                        break;
                    case "4":
                        inventario.ajustePositivoDeInventario();
                        break;
                    case "5":
                        inventario.ajusteNegativoDeInventario();
                        break;
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;

                }

             } 


            
        }

    }
}
