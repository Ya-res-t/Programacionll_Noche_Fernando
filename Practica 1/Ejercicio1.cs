using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            Console.WriteLine("Ingrese el Primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Segundo numero");
            b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("La suma de los numeros es: " + c);
        }
    }
}
