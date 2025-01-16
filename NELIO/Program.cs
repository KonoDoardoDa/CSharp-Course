using System;
using System.Threading.Channels;
using System.Globalization;

class Nelio 
{
    static void Main()
    {
        Console.WriteLine("Entre com seu nome completo: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int qtdQuartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto: ");
        int precoProduto = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Entre com seu ultimo nome, idade e altura (separado por um espaço, por favor: ");

        string[] idx = Console.ReadLine().Split(' ');
        string lastName = idx[0];
        int age = int.Parse(idx[1]);
        double height = double.Parse(idx[2], CultureInfo.InvariantCulture);


        Console.WriteLine(nome);
        Console.WriteLine(qtdQuartos);
        Console.WriteLine(precoProduto);
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(height);

    }




}