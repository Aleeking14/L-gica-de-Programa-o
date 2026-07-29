using System;

namespace Programa10RepetirCadastro
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
            string continuar;

            do
            {
              Console.Clear();
              Console.WriteLine("=================================");
              Console.WriteLine(" CADASTRO DE PESSOA");
              Console.WriteLine("=================================");
              Console.WriteLine();

              Console.Write("Digite o nome: ");
              nome = Console.ReadLine();
              Console.WriteLine();

              Console.WriteLine("Pessoa cadastrada: " + nome);
              Console.WriteLine();
              Console.Write("Deseja realizar outro cadastro? S/N: ");
              continuar = Console.ReadLine();
            }
             while (continuar.ToUpper() == "S");
             Console.WriteLine();

             Console.WriteLine("Programa finalizado.");
             Console.ReadKey();
		}
	}
}