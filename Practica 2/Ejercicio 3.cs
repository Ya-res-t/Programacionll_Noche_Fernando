using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Ingrese la nota del 1 al 100");
            a = int.Parse(Console.ReadLine());
            if (a >= 90 && a < 101)
            {
                Console.WriteLine("Su nota es: A");
            }
            if (a >= 80 && a < 90)
            {
                Console.WriteLine("Su nota es: B");
            }
            if (a >= 70 && a < 80)
            {
                Console.WriteLine("Su nota es: C");
            }
            if (a >= 60 && a < 70)
            {
                Console.WriteLine("Su nota es: D");
            }
            if (a < 60)
            {
                Console.WriteLine("Su nota es: F");
            }
            
        }
    }
}
