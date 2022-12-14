using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agay
{
	public class Program
	{
		static void Main(string[] args)
		{
			int opcion = 0;
			do
			{
				Console.Clear();
				Console.WriteLine("Elige una opcion: ");
				Console.WriteLine("\n1.-Edades: " + "\n2.-Elecciones: " + "\n3.-Empldeado:");
				opcion = Convert.ToInt32(Console.ReadLine());
				switch (opcion)
				{
					case 1:
						Edades.Mayores();
						break;
					//case 2:
					//	Usuario.Delete();
					//	break;
				}
				Console.ReadKey();
			} while (opcion != 2);

		}
	}
}
