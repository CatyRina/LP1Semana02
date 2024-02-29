using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro não-negativo: ");
            if (byte.TryParse(Console.ReadLine(), out byte num))
            {
                byte decremento = num ++;
                byte incremento = num --;

                Console.WriteLine(incremento);
                Console.WriteLine(decremento);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro não-negativo.");
            }
        }
    }
}
