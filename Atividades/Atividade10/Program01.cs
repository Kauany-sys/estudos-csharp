//Programa que encontra o maior valor em uma matriz
using System;
using BibliotecaMatriz;

class Program01
{
    static void Main()
    {
        Console.WriteLine("Digite o Número de Linhas: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Número de Colunas: ");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int [linhas,colunas]; 

        Matriz.GerarMatriz(matriz);
        int maior = matriz[0,0];

        Console.WriteLine($"___Matriz gerada____");
        Matriz.MostrarMatriz(matriz);


        for(int i = 0; i < linhas ; i++)
        {
            for(int j= 0; j < colunas ; j++)
                if(matriz[i , j] > maior)
                    maior  = matriz[i,j];
        }

        Console.WriteLine($"O maior valor encontrado na matriz foi {maior}");


    }
}
