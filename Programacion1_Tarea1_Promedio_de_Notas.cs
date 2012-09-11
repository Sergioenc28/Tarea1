using System;

namespace Tarea_1
	{
		class class1
			{
				static void Main (string [] args)
					{
						int cant_notas = 0;
						int suma = 0;
						int promedio = 0;
						int cant = 0;
						
						Console.Clear();
						Console.WriteLine("Digite la cantidad de notas que introducirá");
						cant_notas = Int32.Parse(Console.ReadLine());
						cant = (cant_notas - 1);
						
						int [] numeros = new int [cant_notas];
						
						for(int cont=0; cont<=cant; cont++)
							{
								Console.Clear();
								Console.WriteLine("Digite la nota y preciones Enter para continuar");
								numeros[cont] = Int32.Parse(Console.ReadLine());
								suma += numeros[cont];
							}
							
						promedio = (suma/cant_notas);
						
						Console.Clear();
						Console.WriteLine("El promedio de las {0} notas que digitó es: {1}",cant_notas,promedio);
				
						Console.ReadKey();	
					}
			}
	}