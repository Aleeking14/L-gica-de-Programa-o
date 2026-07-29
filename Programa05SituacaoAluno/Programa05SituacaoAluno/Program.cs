using System;

namespace Programa05SituacaoAluno
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
            double nota1;
            double nota2;
            double media;

            Console.WriteLine("=================================");
            Console.WriteLine(" SITUAÇÃO DO ALUNO");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");


            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;
            Console.WriteLine();
            Console.WriteLine("Aluno: " + nome);
            Console.WriteLine("Média: " + media.ToString("F2"));
            
            if (media >= 7)
            {
              Console.WriteLine("Situação: APROVADO");
            }
            else if (media >= 5)
            {
              Console.WriteLine("Situação: RECUPERAÇÃO");
            }
            else
            {
              Console.WriteLine("Situação: REPROVADO");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
		}
	}
}