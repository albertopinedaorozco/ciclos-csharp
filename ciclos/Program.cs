/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 2/10/2019
 * Hora: 7:39 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ciclos
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			Console.Write("Digite un valor para base: ");
			int bas = int.Parse(Console.ReadLine());
			
			Console.Write("Digite un valor para exponente: ");
			int exp = int.Parse(Console.ReadLine());

			long resultado=1;
			
			for(int i=1; i<=exp; i++){ //inicio del ciclo
				
				resultado *= bas;
				
			}//fin del ciclo
			
			Console.WriteLine("El resultado es " + resultado);
						
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}