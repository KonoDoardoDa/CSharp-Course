using System;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

class SomaMedia
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao sistema de soma e media do Duds!");
         
        int totalNumeros = 0;
        float soma = 0;


        while (totalNumeros < 3 || totalNumeros > 10)
        {
            Console.WriteLine("Quantos numeros deseja inserir? (entre 3 e 10.)");
            totalNumeros = int.Parse(Console.ReadLine());

            if (totalNumeros < 3 || totalNumeros > 10)
            {
                Console.WriteLine("Digite um numero válido!");
            }
        }

        for (int i = 0;  i < totalNumeros; i++)
        {
            Console.WriteLine($"Insira o número {i + 1}:");
            float numero = float.Parse(Console.ReadLine());
            numeros.Add(numero);
        }


        foreach (float numero in numeros)
        {
            soma += numero;
        }

        float media = soma / totalNumeros;

        Console.WriteLine(media.ToString());
    }
}
