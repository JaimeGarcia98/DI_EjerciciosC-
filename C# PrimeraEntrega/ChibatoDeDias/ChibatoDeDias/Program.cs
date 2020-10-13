using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChibatoDeDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int MesNum;
            int AnoNum;


            Console.WriteLine("Introduce el número del mes");
            MesNum = Convert.ToInt32(
                Console.ReadLine());
            Console.WriteLine("Introduce el número del año");
            AnoNum = Convert.ToInt32(
                Console.ReadLine());

            int chibatodedias = System.DateTime.DaysInMonth(AnoNum, MesNum);
            Console.WriteLine(chibatodedias);
            Console.ReadLine();
        }
    }
}
