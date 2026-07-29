using System;

namespace Programa03MediaAluno
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nomeAluno;
            double nota1;
            double nota2;
            double media;

            Console.WriteLine("=================================");
            Console.WriteLine(" CALCULADORA DE MÉDIA");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;
            Console.WriteLine();
            Console.WriteLine("Aluno: " + nomeAluno);
            Console.WriteLine("Nota 1: " + nota1);
            Console.WriteLine("Nota 2: " + nota2);
            Console.WriteLine("Média: " + media.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
		}
	}
}