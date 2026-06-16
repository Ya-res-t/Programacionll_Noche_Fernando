using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            Console.WriteLine("Ingrese el presio del producto:");
            a = double.Parse(Console.ReadLine());
            b = a * 0.13;
            c = a + b;
            Console.WriteLine("El monto del Iva es: " +b);
            Console.WriteLine("El precio total del producto mas inpuestos es: " + c);
        }
    }
}
