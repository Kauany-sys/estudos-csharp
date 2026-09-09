//Programa que encontra o menor valor em uma matriz
using System;
using BibliotecaMatriz;

class Program02
{
    static void Main()
    {
        Console.WriteLine("Digite o Número de Linhas: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Número de Colunas: ");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int [linhas,colunas]; 

        Matriz.GerarMatriz(matriz);
        int menor = matriz[0,0];

        Console.WriteLine($"___Matriz gerada____");
        Matriz.MostrarMatriz(matriz);


        for(int i = 0; i < linhas ; i++)
        {
            for(int j= 0; j < colunas ; j++)
                if(matriz[i , j] < menor)
                    menor = matriz[i,j];
        }

        Console.WriteLine($"O menor valor encontrado na matriz foi {menor}");
    }
}
