using System;

namespace patronDeDiseñoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            Console.WriteLine(laptop.encender());
            Console.WriteLine(laptop.apagar());
            Console.ReadLine();

            Desktop desktop = new Desktop();
            Console.WriteLine(desktop.encender());
            Console.WriteLine(desktop.apagar());
            Console.ReadLine();

            ComputadoraAdapter maquina = new ComputadoraAdapter();
            Console.WriteLine(maquina.encender());
            Console.WriteLine(maquina.apagar());
            Console.ReadLine();
        }
    }
}
