using System;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

class Calculadora
{
    static (float, float) ReceberDoisNumeros()
    {
        Console.WriteLine("Digite o primeiro número: ");
        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        float numero2 = float.Parse(Console.ReadLine());

        return (numero1, numero2);
    }

    static void Main()
    {
        var operadores = new Dictionary<int, string>
        {
            { 1, "Soma" },
            { 2, "Subtrair"},
            { 3, "Multiplicar" },
            { 4, "Dividir" },
            { 0, "Sair" }
        };


        Console.WriteLine("Bem-vindo à calculadora do Duds!! :D");



        bool continuar = true;

        while (continuar)
        {

            Console.WriteLine("Lista de operadores: ");

            foreach (KeyValuePair<int, string> operador in operadores)
            {
                Console.WriteLine($"{operador.Key} {operador.Value}");
            }

            Console.WriteLine("Escolha um operador pelo seu numero!");
            int operadorEscolhido = int.Parse(Console.ReadLine());

            float num1;
            float num2;

            switch (operadorEscolhido)
            {
                case 1:
                    (num1, num2) = ReceberDoisNumeros();
                    float soma = num1 + num2;
                    Console.WriteLine($"O resultado é: {soma}.");
                    break;

                case 2:
                    (num1, num2) = ReceberDoisNumeros();
                    float subtrair = num1 - num2;
                    Console.WriteLine($"O resultado é: {subtrair}.");
                    break;

                case 3:
                    (num1, num2) = ReceberDoisNumeros();
                    float multiplicar = num1 * num2;
                    Console.WriteLine($"O resultado é: {multiplicar}.");
                    break;

                case 4:
                    (num1, num2) = ReceberDoisNumeros();

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        break;
                    }

                    float dividir = num1 / num2;
                    Console.WriteLine($"O resultado é: {dividir}.");
                    break;

                case 0:
                    Console.WriteLine("Saindo da calculadora...");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;

            }
        }
    }
}