using System;
using System.Diagnostics;

class JogarDados
{
    static (string, string) ReceiveTwoNames()
    {

            Console.WriteLine("Digite o nome do player1: ");
            string player1Name = Console.ReadLine();

            Console.WriteLine("Digite o nome do player2: ");
            string player2Name = Console.ReadLine();

        // Adicionar uma verificação caso os nomes sejam iguais
        // e outra para caso a entrada de nome tenha sido incorreta(ex: numeros etc...)

        return (player1Name, player2Name);
    }

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao jogo de Dados do Duds, (apenas 2 players e os nomes dos players devem ser diferentes!)");
        
        string name1;
        string name2;
        int ciclo = 1;
        int contadorP1 = 0;
        int contadorP2 = 0;

        (name1, name2) = ReceiveTwoNames();

        if (name1 != name2)
        {
            while (ciclo <= 3)
            {
                Random random = new Random();
                int inteiroAleatorio1 = random.Next(1, 6);
                int inteiroAleatorio2 = random.Next(1, 6);

                Console.WriteLine($"{name1} tirou {inteiroAleatorio1} e {name2} tirou {inteiroAleatorio2} na rodada {ciclo}!");
              
                if (inteiroAleatorio1 == inteiroAleatorio2)
                {
                    Console.WriteLine("Ninguém pontuou nesta rodada");
                }
                else if (inteiroAleatorio1 > inteiroAleatorio2)
                {
                    contadorP1 += inteiroAleatorio1;
                }
                else
                {
                    contadorP2 += inteiroAleatorio2;
                }

                if (ciclo <= 2)
                {

                    Console.WriteLine($"{name1} pontuou {contadorP1} até então.");
                    Console.WriteLine($"{name2} pontuou {contadorP2} até então.");
                }
                else if (ciclo == 3)
                {
                    if (contadorP1 == contadorP2)
                    {
                        Console.WriteLine($"Empatou!");
                    }
                    if (contadorP1 > contadorP2)
                    {
                        Console.WriteLine($"{name1} venceu, pontuando: {contadorP1} pontos.");
                    }
                    else
                    {
                        Console.WriteLine($"{name2} venceu, pontuando: {contadorP2} pontos.");
                    }
                }
                Console.ReadLine();
                ciclo++;
            }
        }
        else
        {
            Console.WriteLine("Você inseriu nomes idênticos!");
        }
    }
}