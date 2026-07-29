using System;

namespace Programa07MenuCalculadora
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcao;
            double numero1;
            double numero2;
            double resultado;

            Console.WriteLine("====================");
            Console.WriteLine(" CALCULADORA SIMPLES");
            Console.WriteLine("====================");
            
            Console.WriteLine();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");

            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());


            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcao)
            {
             case 1:
             resultado = numero1 + numero2;
             Console.WriteLine("Resultado: " + resultado);
             break;
             case 2:
             resultado = numero1 - numero2;
             Console.WriteLine("Resultado: " + resultado);
             break;
             case 3:
             resultado = numero1 * numero2;
             Console.WriteLine("Resultado: " + resultado);
             break;
             case 4:

             if (numero2 != 0)
             {
               resultado = numero1 / numero2;
               Console.WriteLine("Resultado: " + resultado);
             }
             else
             {
               Console.WriteLine("Não é possível dividir por zero.");
             }
             break;
             
             default:
             Console.WriteLine("Opção inválida.");
             break;
             }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar.");
            Console.ReadKey();
		}
	}
}