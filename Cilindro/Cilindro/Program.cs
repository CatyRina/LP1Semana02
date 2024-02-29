using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a altura (a) do cilindro:");
        float altura = float.Parse(Console.ReadLine());

        Console.WriteLine("Insira o raio (r) do cilindro:");
        float raio = float.Parse(Console.ReadLine());

        float volume = MathF.PI * MathF.Pow(raio, 2) * altura;
        float areaSuperficie = 2 * MathF.PI * raio * (raio + altura);

        Console.WriteLine(volume);
        Console.WriteLine(areaSuperficie);
    }
}

