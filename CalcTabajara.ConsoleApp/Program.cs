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
                Console.WriteLine("Digite 3 para divisão: ");
                Console.WriteLine("Digite 4 para multiplicação: ");




                double operacao = Convert.ToDouble(Console.ReadLine());

                if (operacao != 1 || operacao != 2 || operacao != 3 || operacao != 4 || operacao != 5)
                {
                    Console.WriteLine("Você digitou uma opção invalida, tente novamente");
                    Console.ReadLine();
                    continue;
                }

                if (operacao == 5)
                    break;

                double resultado;

            switch (operacao)
            {
                case 1:
                    resultado = num1 + num2;
                    operador = "+";
                    break;

                case 2:
                    resultado = num1 - num2;
                    operador = "-";
                    break;

                case 3:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        operador = "/";
                    }
                    else
                        Console.WriteLine("O divisor não pode ser zero.");
                    break;

                case 4:
                    resultado = num1 * num2;
                    operador = "*";
                    break;
            }
            Console.WriteLine($"Operação realizada: {num1} {operador} {num2} = {resultado}");

        }
    }
}
