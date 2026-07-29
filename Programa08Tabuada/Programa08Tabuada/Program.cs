using System;

namespace Programa08Tabuada
{
	class Program
	{
		public static void Main(string[] args)
		{
			 int numero;
             int resultado;

             Console.WriteLine("========");
             Console.WriteLine(" TABUADA");
             Console.WriteLine("========");
             Console.WriteLine();

             Console.Write("Digite um número: ");
             numero = int.Parse(Console.ReadLine());
             Console.WriteLine();

             Console.WriteLine("Tabuada do número " + numero);
             Console.WriteLine();

             for (int contador = 1; contador <= 10; contador++)
             {
               resultado = numero * contador;
               Console.WriteLine(numero + " x " + contador + " = " + resultado);
             }
             Console.WriteLine();

             Console.WriteLine("Pressione qualquer tecla para finalizar.");
             Console.ReadKey();
		}
	}
}