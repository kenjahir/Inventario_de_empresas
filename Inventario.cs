using System;
using System.Collections.Generic;

public class Inventario
{
    public List<Inventario> ListaInventario { get; set; }
    public Inventario()
    {
        ListaInventario = new List<Inventario>();

        Inventario a = new Inventario("001", "iPhone", 0);
        Inventario b = new Inventario("002", "HP", 5);
        Inventario c = new Inventario("003", "Monitor Dell", 2);
        Inventario d = new Inventario("004", "Mouse", 100);
        Inventario e = new Inventario("005", "PC", 25);

        ListaInventario.Add(a);
        ListaInventario.Add(b);
        ListaInventario.Add(c);
        ListaInventario.Add(d);
        ListaInventario.Add(e
        }

    public void listaInventario() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Lista de Productos ");
        Console.WriteLine("********************");
        Console.WriteLine("Codigo,Descripcion y Existencia");

        foreach (var producto in ListaInventario)
        {
            Console.WriteLine(producto.Codigo + "│" + producto.Descripcion + "│" + producto.Existencial.ToString());
        }
        Console.ReadLine();
    }
    private void movimientoInventario(string codigo, in cantidad, string tipomovimiento) {
        foreach (var producto in ListaInventario)
        {
            if (producto.Codigo == codigo)
            {
                if (tipomovimiento == "+")
                {
                    producto.Existencia = producto.Existencia + cantidad;

                }
                else
                {
                    producto.Existencia = producto.Existencia - cantidad;

                }
            }

        }

    }
    public void salidadeInventario() {
        string codigo = "";
        string canrtidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Salida de Productos del inventario");
        Console.WriteLine("******+**********+*****************");
        Console.WriteLine("Ingrese el codigo del producto");
        codigo = Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del cantidad");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");

        public void ajustePositivoDeInventario();
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Ajuste Positivo De Inventario");
        Console.WriteLine("******************************");
        Console.WriteLine("Ingrese la codigo del produto");
        codigo = Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto");
        cantidad = Console.ReadLine();
        Console.WriteLine("Producto agregado con exito");

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");

        public void ajusteNegativoDeInventario();
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Ajuste Negativo De Inventario");
        Console.WriteLine("******************************");
        Console.WriteLine("Ingrese el codigo del producto"):;
        codigo = Console.ReadLine();
        Console.WriteLine();

        movimientoInventario(codigo.Insert Int32.Parse(cantidad)."-");
    }
}









    
