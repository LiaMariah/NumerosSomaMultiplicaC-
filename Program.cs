//LIA MARIAH COUTO OLIVO
using System;

class NumerosSomaMultiplica
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        double resultado = (n1 + n2) * n1;

        Console.WriteLine("O primeiro número lido foi " + n1 + ", o segundo numero lido foi " + n2 +". O resultado final é: " + resultado);
    }
}