//Programa Desafio do Tesouro da Ilha Desconhecida: compara as somas das diagonais
using System;

class Ex11
{
    //Função que preenche a matriz com moedas de 1 a 100
    static void GerarMapa(int[,] mapa)
    {
        Random random = new Random();
        int n = mapa.GetLength(0);

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
                mapa[i,j] = random.Next(1, 101);
        }
    }

    static void MostrarMapa(int[,] mapa)
    {
        int n = mapa.GetLength(0);

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
                Console.Write($"{mapa[i,j],4}");

            Console.WriteLine();
        }
    }

    static int SomarDiagonalPrincipal(int[,] mapa)
    {
        int n = mapa.GetLength(0);
        int soma = 0;

        for(int i = 0; i < n; i++)
            soma += mapa[i,i];

        return soma;
    }

    static int SomarDiagonalSecundaria(int[,] mapa)
    {
        int n = mapa.GetLength(0);
        int soma = 0;

        for(int i = 0; i < n; i++)
            soma += mapa[i,n - 1 - i];

        return soma;
    }

    static void Main()
    {
        Console.Write("Digite o tamanho N do mapa: ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] mapa = new int[n,n];

        GerarMapa(mapa);

        Console.WriteLine("Mapa do Tesouro (Quantidade de Moedas em Cada Região):");
        MostrarMapa(mapa);

        int principal = SomarDiagonalPrincipal(mapa);
        int secundaria = SomarDiagonalSecundaria(mapa);

        Console.WriteLine();
        Console.WriteLine($"Soma da Diagonal Principal: {principal}");
        Console.WriteLine($"Soma da Diagonal Secundária: {secundaria}");
        Console.WriteLine();

        if(principal > secundaria)
            Console.WriteLine("O maior tesouro está na diagonal principal, vamos para lá!");
        else if(secundaria > principal)
            Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
        else
            Console.WriteLine("As duas diagonais têm a mesma quantidade de moedas, escolham qualquer uma!");
    }
}