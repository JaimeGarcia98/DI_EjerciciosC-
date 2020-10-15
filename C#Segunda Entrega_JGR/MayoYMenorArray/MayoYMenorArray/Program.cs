using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MayoYMenorArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = { 1, 3, 7, 10, 100, 250, 7 };

            Array.Sort(valores);

            int maximo = valores[valores.Length - 1];
            int minimo = valores[0];

            Console.WriteLine("El valor minimo es: " + minimo);
            Console.WriteLine("El valor maximo es: " + maximo);

            Console.ReadLine();
        }
    }
}
