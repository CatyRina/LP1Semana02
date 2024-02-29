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
                byte decremento = --num;
                byte incremento = num++;

                Console.WriteLine(incremento);
                Console.WriteLine(decremento);

                byte divisaoPorDois = (byte)(num / 2);
                byte shiftLeftPorTres = (byte)(num << 3);
                byte xorComCinco = (byte)(num ^ 5);
                bool maiorQueDez = num > 10;

                Console.WriteLine(divisaoPorDois);
                Console.WriteLine(shiftLeftPorTres);
                Console.WriteLine(xorComCinco);
                Console.WriteLine(maiorQueDez);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro não-negativo.");
            }
        }
    }
}

