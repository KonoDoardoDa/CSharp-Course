using System;
using System.Numerics;

class JogoDaForca
{
    static string sorteio()
    {
        Console.WriteLine("Pressione (ENTER) para que aleatoriamente seja escolhido um dos 3 temas (Filmes, carros ou países):");

        
        Random random = new Random();
        
        int CategoriaAleatoria = random.Next(1, 3);

        switch(CategoriaAleatoria) {
            case 1:
                string filme = "matrix";
                Console.WriteLine(filme);
                break;
            case 2:
                string carro = "Agile";
                Console.WriteLine(carro);
                break;
            case 3:
                string pais = "Brasil";
                Console.WriteLine(pais);
                break;
        }
        return CategoriaAleatoria;
    }

    static void main()
    {
        Console.WriteLine(sorteio());
    }
    




}