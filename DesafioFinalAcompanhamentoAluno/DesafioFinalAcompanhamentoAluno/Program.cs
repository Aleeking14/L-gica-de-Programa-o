using System;

namespace DesafioFinalAcompanhamentoAluno
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nome;
            int idade;
            double nota1;
            double nota2;
            double nota3;
            double media;
            int faltas;
            string situacao;
            string continuar;

            do
            {
                Console.Clear();

                Console.WriteLine("========================================");
                Console.WriteLine(" SISTEMA DE ACOMPANHAMENTO DE ALUNOS");
                Console.WriteLine("========================================");
                Console.WriteLine();

                Console.Write("Digite o nome do aluno: ");
                nome = Console.ReadLine();

                do
                {
                    Console.Write("Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());

                    if (idade < 0)
                    {
                        Console.WriteLine("Idade inválida.");
                    }

                } while (idade < 0);

                do
                {
                    Console.Write("Digite a primeira nota (0 a 10): ");
                    nota1 = double.Parse(Console.ReadLine());

                    if (nota1 < 0 || nota1 > 10)
                    {
                        Console.WriteLine("Nota inválida.");
                    }

                } while (nota1 < 0 || nota1 > 10);

                do
                {
                    Console.Write("Digite a segunda nota (0 a 10): ");
                    nota2 = double.Parse(Console.ReadLine());

                    if (nota2 < 0 || nota2 > 10)
                    {
                        Console.WriteLine("Nota inválida.");
                    }

                } while (nota2 < 0 || nota2 > 10);

                do
                {
                    Console.Write("Digite a terceira nota (0 a 10): ");
                    nota3 = double.Parse(Console.ReadLine());

                    if (nota3 < 0 || nota3 > 10)
                    {
                        Console.WriteLine("Nota inválida.");
                    }

                } while (nota3 < 0 || nota3 > 10);

                do
                {
                    Console.Write("Digite a quantidade de faltas: ");
                    faltas = int.Parse(Console.ReadLine());

                    if (faltas < 0)
                    {
                        Console.WriteLine("Quantidade de faltas inválida.");
                    }

                } while (faltas < 0);

                // Calcula a média das três notas
                media = (nota1 + nota2 + nota3) / 3;

                // Verifica a situação do aluno
                if (faltas > 10)
                {
                    situacao = "REPROVADO POR FALTAS";
                }
                else if (media >= 7)
                {
                    situacao = "APROVADO";
                }
                else if (media >= 5)
                {
                    situacao = "RECUPERAÇÃO";
                }
                else
                {
                    situacao = "REPROVADO POR NOTA";
                }

                Console.WriteLine();
                Console.WriteLine("========================================");
                Console.WriteLine("      RESULTADO DO ALUNO");
                Console.WriteLine("========================================");
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade + " anos");
                Console.WriteLine("Nota 1: " + nota1.ToString("F2"));
                Console.WriteLine("Nota 2: " + nota2.ToString("F2"));
                Console.WriteLine("Nota 3: " + nota3.ToString("F2"));
                Console.WriteLine("Média: " + media.ToString("F2"));
                Console.WriteLine("Faltas: " + faltas);
                Console.WriteLine("Situação: " + situacao);

                Console.WriteLine();
                Console.Write("Deseja cadastrar outro aluno? (S/N): ");
                continuar = Console.ReadLine();

            } while (continuar.ToUpper() == "S");

            Console.WriteLine();
            Console.WriteLine("Sistema finalizado.");
            Console.WriteLine("Pressione qualquer tecla para fechar.");
            Console.ReadKey();
		}
	}
}