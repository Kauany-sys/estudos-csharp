//Programa que conta quantas vezes um valor X aparece em uma matriz
using System;
using BibliotecaMatriz;

class Ex05
{
    //Função que retorna quantas ocorrências de x existem na matriz
    static int ContarOcorrencias(int[,] matriz, int x)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int contador = 0;

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
                if(matriz[i,j] == x)
                    contador++;
        }

        return contador;
    }

    static void Main()
    {
        Console.Write("Digite o número de linhas: ");
        int linhas = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o número de colunas: ");
        int colunas = int.Parse(Console.ReadLine()!);

        int[,] matriz = new int[linhas,colunas];

        Matriz.GerarMatriz(matriz);

        Console.WriteLine("___Matriz gerada___");
        Matriz.MostrarMatriz(matriz);

        Console.Write("Digite o valor X a ser procurado: ");
        int x = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"O valor {x} aparece {ContarOcorrencias(matriz, x)} vez(es) na matriz");
    }
}