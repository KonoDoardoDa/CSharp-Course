using System;
using System.Globalization;

public class Data
{
    public void ConfigData()
    {
        DateTime sistema = DateTime.Now;



        

    }
    static void Main()
    {
        DateTime sistema = DateTime.Now;

        Console.WriteLine("Escolha uma das configurações de data abaixo: (insira o indice para escolher a opção!)");

        Console.WriteLine("1- Utilizar minha configuração de sistema: (08/01/2021 20:48:13)");
        Console.WriteLine("2- Formato simples: (08/01/21)");
        Console.WriteLine("3- Formato longo: (sexta-feira, 8 de janeiro de 2021)");
        Console.WriteLine("4- Formato longo personalizado: (08/01/2021 08:48:13)");
        Console.WriteLine("5- Formato RFC1123 pattern: (Fri, 08 Jan 2021 20:48:13 GMT)");

        int configEscolhida = int.Parse(Console.ReadLine());


        switch (configEscolhida)
        {
            case 1:
                Console.WriteLine(sistema.ToString());
                break;

            case 2:
                Console.WriteLine(sistema.ToString("dd/MM/yyyy"));
                break;

            case 3:
                Console.WriteLine(sistema.ToString("F"));
                break;

            case 4:
                Console.WriteLine(sistema.ToString("dd/MM/yyyy hh:mm:ss"));
                break;

            case 5:
                Console.WriteLine(sistema.ToString("R"));
                break;

            default:
                Console.WriteLine("Opção inválida, tente novamente!");
                break;
        }
    }
}