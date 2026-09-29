//Programa que gera uma matriz N x N e apresenta a diagonal secundária
using System;
using BibliotecaMatriz;

class Ex04
{
    //Função que apresenta a diagonal secundária
    static void MostrarDiagonalSecundaria(int[,] matriz)
    {
        int n = matriz.GetLength(0);

        for(int i = 0; i < n; i++)
            Console.Write($"{matriz[i,n - 1 - i]} ");

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Digite a ordem da matriz: ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[n,n];

        Matriz.GerarMatriz(matriz);

        Console.WriteLine("___Matriz gerada___");
        Matriz.MostrarMatriz(matriz);

        Console.WriteLine("Diagonal secundária: ");
        MostrarDiagonalSecundaria(matriz);
    }
}