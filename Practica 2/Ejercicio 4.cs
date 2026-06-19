using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejejrcicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a = 0, b = 0, c = 0;
                int opcion = 0;
                Console.WriteLine("");
                Console.WriteLine("CALCULADORA");
                Console.WriteLine(" 1. Sumar (+)");
                Console.WriteLine(" 2. Restar (-)");
                Console.WriteLine(" 3. Multiplicar (*)");
                Console.WriteLine(" 4. Dividir (/)");
                Console.WriteLine("Ingrese la operacion: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el primer numero:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:");
                b = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        c = a + b;
                        Console.WriteLine("El resultados es: " + c);
                        break;
                    case 2:
                        c = a - b;
                        Console.WriteLine("El resultados es: " + c);
                        break;
                    case 3:
                        c = a * b;
                        Console.WriteLine("El resultados es: " + c);
                        break;
                    case 4:
                        if (a == 0 || b == 0)
                        {
                            Console.WriteLine("No tiene resultado");
                        }
                        else
                        {
                            c = a / b;
                            Console.WriteLine("El resultado es");
                        }
                        break;
                }
            }
        }
    }
}
