using System;

namespace Programa09ControleSenha
{
	class Program
	{
		public static void Main(string[] args)
		{
			string senhaDigitada;
            string senhaCorreta = "1234";

            Console.WriteLine("===================");
            Console.WriteLine(" CONTROLE DE ACESSO");
            Console.WriteLine("===================");
            Console.WriteLine();

            Console.Write("Digite a senha: ");
            senhaDigitada = Console.ReadLine();
            while (senhaDigitada != senhaCorreta)
            {
              Console.WriteLine();
              Console.WriteLine("Senha incorreta.");
              Console.Write("Digite a senha novamente: ");
              senhaDigitada = Console.ReadLine();
            }
              Console.WriteLine();

              Console.WriteLine("Senha correta.");
              Console.WriteLine("Acesso permitido.");
              Console.WriteLine();

              Console.WriteLine("Pressione qualquer tecla para finalizar.");
              Console.ReadKey();
		}
	}
}