//Programa Aventura no Reino das Matrizes: força total das tropas de cada região
using System;

class Ex09
{
    //Função que preenche a matriz com tropas de 0 a 100
    static void GerarTropas(int[,] tropas)
    {
        Random random = new Random();
        int regioes = tropas.GetLength(0);
        int cidades = tropas.GetLength(1);

        for(int i = 0; i < regioes; i++)
        {
            for(int j = 0; j < cidades; j++)
                tropas[i,j] = random.Next(0, 101);
        }
    }

    static void MostrarTropas(int[,] tropas)
    {
        int regioes = tropas.GetLength(0);
        int cidades = tropas.GetLength(1);

        for(int i = 0; i < regioes; i++)
        {
            Console.Write($"Região {i + 1}:");

            for(int j = 0; j < cidades; j++)
                Console.Write($" {tropas[i,j]}");

            Console.WriteLine();
        }
    }

    //Função que soma as tropas de uma região (linha da matriz)
    static int SomarRegiao(int[,] tropas, int regiao)
    {
        int cidades = tropas.GetLength(1);
        int soma = 0;

        for(int j = 0; j < cidades; j++)
            soma += tropas[regiao,j];

        return soma;
    }

    static void Main()
    {
        Console.Write("Digite o número de regiões: ");
        int r = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o número de cidades por região: ");
        int c = int.Parse(Console.ReadLine()!);

        int[,] tropas = new int[r,c];

        GerarTropas(tropas);

        Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
        MostrarTropas(tropas);

        Console.WriteLine();
        Console.WriteLine("Força Total das Regiões:");

        for(int i = 0; i < r; i++)
            Console.WriteLine($"Região {i + 1}: {SomarRegiao(tropas, i)} tropas");
    }
}