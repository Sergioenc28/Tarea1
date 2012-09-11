using System;

namespace Programacion1_Tarea1_FactorialNúmero
{
	class Programa
	{
		static void Main (string [] args)
		{
			
			int numero = 0;
			int resultado = 1;
			bool sigue = true;
			
			
			
			while(sigue)
			{
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Clear();
				Console.WriteLine("Este Programa te permite saber el Factorial de un Número con solo digitar dicho numero\n");
				Console.Write("Inserte un Número: ");
				numero = Int32.Parse(Console.ReadLine());
			
				if(numero < 2)
				{
					Console.BackgroundColor = ConsoleColor.DarkBlue;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Clear();
					Console.WriteLine("\nEl numero introducido es menor que (2), asegurece de ingresar un numero mayor a este.\n");
					Console.ReadKey();
					sigue = false;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Clear();
				}
				
				if (numero >= 12)
				{
					Console.BackgroundColor = ConsoleColor.DarkBlue;
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Clear();
					Console.WriteLine("El numero introducido es mayor que (12), or lo que su factorial contiene una alta cantidad de digitos");
					Console.ReadKey();
					sigue = false;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Clear();
				}
				else
				{
					Console.Clear();
					for(int x = numero; x > 1; x--)
					{
						resultado = resultado * x;
					}
					
					Console.BackgroundColor = ConsoleColor.White;
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Clear();
					Console.WriteLine("El Resultado Factorial del Número {0} es: {1}",numero,resultado);
					sigue = false;
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.Green;
					Console.ReadKey();
					Console.Clear();
				}
			}
		}
	}
}