using System;

namespace CalcTabajara.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Primeiro número:");
                double num1 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Digite 1 para soma: ");
                Console.WriteLine("Digite 2 para subtração: ");
                Console.WriteLine("Digite 5 para sair: ");
                double operacao = Convert.ToDouble(Console.ReadLine());

                if (operacao != 1 || operacao != 2 || operacao != 3 || operacao != 4 || operacao != 5)
                {
                    Console.WriteLine("Você digitou uma opção invalida, tente novamente");
                    Console.ReadLine();
                    continue;
                }

                double resultado;

                switch (operacao)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;

                    case 2:
                        resultado = num1 - num2;
                        break;

                    case 3:
                        resultado = num1 / num2;
                        break;

                    case 4:
                        resultado = num1 * num2;
                        break;
                }
            }
        }
    }
}
