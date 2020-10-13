using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 2;
            int valor2 = 5;
            Console.Write("La suma de " + valor1 + " + " + valor2 + " es igual a: " );
            Console.WriteLine(valor1 + valor2);
            Console.Write("La resta de " + valor1 + " - " + valor2 + " es igual a: ");
            Console.WriteLine(valor1 - valor2);
            Console.Write("La multiplicación de " + valor1 + " x " + valor2 + " es igual a: ");
            Console.WriteLine(valor1 * valor2);
            Console.Write("La división de " + valor1 + " / " + valor2 + " es igual a: ");
            Console.WriteLine(valor1 / valor2);
            Console.ReadLine();
        }
    }
}
