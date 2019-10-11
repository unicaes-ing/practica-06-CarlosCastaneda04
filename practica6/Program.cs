using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    class Program
    {
        public static void Tabla(int num)
        {
            Console.WriteLine("Tabla de Multliplicacion: ");
            Console.WriteLine();
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        }
        public static void Tabla(int num, ConsoleColor texto)
        {
            Console.WriteLine("Tabla de Multliplicacion: ");
            Console.WriteLine();
            for (int i = 1; i < 13; i++)
            {
                Console.ForegroundColor = texto;
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        }
        static void Main(string[] args)
        {
            int nume;
            Console.WriteLine("Ingrese el numero a multlipicar: ");
            nume = int.Parse(Console.ReadLine());
            Console.Clear();
            Tabla(nume);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese el numero a multlipicar: ");
            nume = int.Parse(Console.ReadLine());
            Console.Clear();
            Tabla(nume, ConsoleColor.Red);
            Console.ReadKey();
        }
    }
}
