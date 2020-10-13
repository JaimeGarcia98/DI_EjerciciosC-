using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaSietes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];
            int i;
            int mayor = -1;
            int indice = 0;
            int numerode7 = 0;
            Console.WriteLine("Leer 10 numeros enteros, almacenarlos en un vector y determinar el mayor");
            Console.WriteLine("");

            for (i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Escribe un numero {0}", i + 1);
                int.TryParse(Console.ReadLine(), out numero[i]);

            }

            for (i = 0; i < numero.Length; i++)
            {
                Console.WriteLine(i + " - " + numero[i]);


            }

            for (i = 0; i < numero.Length; i++)
            {
                if (numero[i] == 7)
                {
                    numerode7++;
                }

            }

            Console.WriteLine("La cantidad de 7 es {0}", numerode7);



            Console.ReadKey();
        }
    }
}
