using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear tipo de dato
            int numero = 0;
            // Salida de textos
            Console.WriteLine("Hola progra 2");
            Console.WriteLine("Ingrese datos");
            //Ingresar valores
            numero = int.Parse(Console.ReadLine());
            //Salida de valores
            Console.WriteLine("El numero ingresado es: " + numero);

        }
    }
}
