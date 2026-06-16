using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0, c = 0, d = 0;
            Console.WriteLine("Ingrese la primera nota:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            c = float.Parse(Console.ReadLine());
            d = (a + b + c) / 3;
            Console.WriteLine("El promedio de las 3 notas es: " +d);

        }
    }
}
