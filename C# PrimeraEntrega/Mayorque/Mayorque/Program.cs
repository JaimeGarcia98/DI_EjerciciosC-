using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorque
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            

           Console.WriteLine("Introduce el primer número");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            segundoNumero = System.Convert.ToInt32(
                Console.ReadLine());
            if (primerNumero > segundoNumero)
            {
                Console.WriteLine("El mayor de los numeros es: " + primerNumero);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El mayor de los numeros es: " + segundoNumero);
                Console.ReadLine();
            }
        }
    }
}
