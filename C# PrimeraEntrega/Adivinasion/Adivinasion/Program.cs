using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinasion
{
    class Program
    {
        static void Main(string[] args)
        {

				const int oportunidades = 5;
				int num; 
				int entrada;
				byte i;
				byte adivinado;
				string linea;

				
				Random ran = new Random(0 - 20);
				num = Convert.ToInt32(ran.Next(100)) + 1;

				i = 1; adivinado = 0;
				do
				{
					Console.Write("Piensa un numero entre 0 y 20:");
					linea = Console.ReadLine();
					entrada = int.Parse(linea);

					if ((entrada == num))
					{
						Console.WriteLine("Has adivinado el numero");
						adivinado = 1;
					}
					else
					{
						if ((entrada > num))
						{
							Console.WriteLine("Estas alto");
						}
						else
						{
							Console.WriteLine("Estas bajo");
						}
					}
					i++;
				} while (((i <= oportunidades) & (adivinado == 0)));
				if ((adivinado == 0))
				{
					Console.Write("Has agotado los intentos... El numero fue: " + num);
				}

				Console.WriteLine();
				Console.Write("Pulse una Tecla:");
				Console.ReadLine();
			}
    }
}
