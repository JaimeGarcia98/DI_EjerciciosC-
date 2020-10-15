using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczepzioneCsard
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            try
            {
                Console.WriteLine("Introduzca el primer numero");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo numero");
                y = Convert.ToInt32(Console.ReadLine());

                double result = x / y;
                Console.WriteLine("La división es: " + result);
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No Se Permite Division Entre 0");
            }
            catch(FormatException)
            {
                Console.WriteLine("No metas letras cazurro!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Excediste la longitud soportada");
            }
            Console.ReadKey();
        }
    }
}
