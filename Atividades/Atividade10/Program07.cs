//Programa que soma duas matrizes, verificando antes se são de mesma ordem
using System;
using BibliotecaMatriz;

class Ex07
{
    //Função que calcula e apresenta a soma de duas matrizes
    static void SomarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);

        //Verifica se as matrizes são de mesma ordem
        if(linhas != matriz2.GetLength(0) || colunas != matriz2.GetLength(1))
        {
            Console.WriteLine("As matrizes não são de mesma ordem, não é possível somar.");
            return;
        }

        int[,] soma = new int[linhas,colunas];

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
                soma[i,j] = matriz1[i,j] + matriz2[i,j];
        }

        Console.WriteLine("___Soma das matrizes___");
        Matriz.MostrarMatriz(soma);
    }

    static void Main()
    {
        Console.WriteLine("Primeira matriz");
        Console.Write("Digite o número de linhas: ");
        int linhas1 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o número de colunas: ");
        int colunas1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Segunda matriz");
        Console.Write("Digite o número de linhas: ");
        int linhas2 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o número de colunas: ");
        int colunas2 = int.Parse(Console.ReadLine()!);

        int[,] matriz1 = new int[linhas1,colunas1];
        int[,] matriz2 = new int[linhas2,colunas2];

        Matriz.GerarMatriz(matriz1);
        Matriz.GerarMatriz(matriz2);

        Console.WriteLine("___Primeira matriz___");
        Matriz.MostrarMatriz(matriz1);

        Console.WriteLine("___Segunda matriz___");
        Matriz.MostrarMatriz(matriz2);

        SomarMatrizes(matriz1, matriz2);
    }
}