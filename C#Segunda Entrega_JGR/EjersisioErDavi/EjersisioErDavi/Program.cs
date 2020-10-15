using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjersisioErDavi
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] valores = { 7, 5, 17, 256, 32, 200 };

            int suma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                suma += valores[i];
            }

            double media;
            media = (double) suma / valores.Length;

            Console.WriteLine("La media es " + media);

            Console.ReadLine();
        }
    }
}
