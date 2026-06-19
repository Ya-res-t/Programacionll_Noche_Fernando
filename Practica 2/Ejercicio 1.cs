using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Ingrese el numero entero");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            if (a % 2 == 1)
            {
                Console.WriteLine("El numero es impar");
            } 
        }
    }
}
