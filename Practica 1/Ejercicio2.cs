using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Ingrese la base del triangulo:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo:");
            b = int.Parse(Console.ReadLine());
            c = (a * b) / 2;
            Console.WriteLine("El area del triangulo es: " + c);
        }
    }
}
