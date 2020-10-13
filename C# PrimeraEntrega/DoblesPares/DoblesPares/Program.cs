using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoblesPares
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
            if (primerNumero % 2 == 0 && segundoNumero % 2 == 0)
            {
                Console.WriteLine("Ambos números son pares :) ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Los dos números no son pares :( ");
                Console.ReadLine();
            }
        }
    }
}
