using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Ingrese 3 numeros");
            Console.WriteLine("Primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercer numero: ");
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("El mayor es " +a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("El mayor es "  +b);
            }
            if (c > b && c > a)
            {
                Console.WriteLine("El mayor es " +c);
            }
        }
    }
}
