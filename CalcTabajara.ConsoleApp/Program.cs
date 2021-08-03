using System;

namespace CalcTabajara.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite 1 para soma: ");
            Console.WriteLine("Digite 2 para subtração: ");
            double operacao = Convert.ToDouble(Console.ReadLine());

            double resultado;

            switch (operacao)
            {
                case 1:
                    resultado = num1 + num2;
                    break;

                case 3:
                    resultado = num1 * num2;
                    break;
            }
        }
    }
}
