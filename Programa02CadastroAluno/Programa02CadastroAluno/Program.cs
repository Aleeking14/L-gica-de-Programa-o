using System;

namespace Programa02CadastroAluno
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
            int idade;
            string curso;

            Console.WriteLine("=================================");
            Console.WriteLine(" CADASTRO DE ALUNO");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a idade do aluno: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do curso: ");
            curso = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("CADASTRO REALIZADO");
            Console.WriteLine("Nome: " + nome);


            Console.WriteLine("Idade: " + idade + " anos");
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
		}
	}
}