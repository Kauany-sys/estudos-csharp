using System;
using BibliotecaMatriz;

class Ex01
{
        static void Main()
    {
        int linhas = 3;
        int colunas = 3;
        int[,] matriz = new int[linhas,colunas];

        Matriz.GerarMatriz(matriz);
        Matriz.MostrarMatriz(matriz);

        Console.ReadKey();

    }
}