using System;

class Soma
{
    static void Main()
    {
        Console.WriteLine("Insira um número para realizar soma: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira outro número para realizar soma: ");
        int n2 = int.Parse(Console.ReadLine());

        int calculo = n1 + n2;
        Console.WriteLine($"SOMA = {calculo}");
    }


}