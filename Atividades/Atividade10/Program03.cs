//Programa que gera uma matriz N x N e apresenta a diagonal principal
using System;
using BibliotecaMatriz;

class Ex03
{
    //Função que apresenta a diagonal principal
    static void MostrarDiagonalPrincipal(int[,] matriz)
    {
        int n = matriz.GetLength(0);

        for(int i = 0; i < n; i++)
            Console.Write($"{matriz[i,i]} ");

        Console.WriteLine();
    }

    static void Main()
    {
        int n;
        {
            Console.Write("Digite a ordem da matriz (1 a 100): ");
            n = int.Parse(Console.ReadLine()!);
        } while(n < 1 || n > 100);

        int[,] matriz = new int[n,n];

        Matriz.GerarMatriz(matriz);

        Console.WriteLine("___Matriz gerada___");
        Matriz.MostrarMatriz(matriz);

        Console.WriteLine("Diagonal principal: ");
        MostrarDiagonalPrincipal(matriz);
    }
}