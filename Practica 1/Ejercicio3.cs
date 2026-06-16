using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            Console.WriteLine("Ingrese los Bolivianos:");
            a = double.Parse(Console.ReadLine());
            b = a / 6.96;
            Console.WriteLine("En dolares es equivalente a: " +b);
        }
    }
}
