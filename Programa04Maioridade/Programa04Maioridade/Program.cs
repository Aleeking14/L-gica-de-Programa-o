using System;

namespace Programa04Maioridade
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
            int idade;
            
            Console.WriteLine("=================================");
            Console.WriteLine(" VERIFICAÇÃO DE IDADE");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (idade >= 18)
            {
              Console.WriteLine(nome + ", você é maior de idade.");
            }
            else
            {
              Console.WriteLine(nome + ", você é menor de idade.");
            }


            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
		}
	}
}