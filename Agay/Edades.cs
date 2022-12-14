using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Agay
{
	public class Edades
	{
     public static void Mayores()
		{
			
			Random random= new Random();

			//for (int i = 0; i < 20; i++)
			//{
				if (random >=18)
				{
					Console.WriteLine(random.Next(1, 20));
					Console.WriteLine("Es Mayor de Edad: ");
				}
				else
				{
					Console.WriteLine("Es Menor de Edad: ");
				}
				Console.ReadLine();
			//}


		}


	}
}
