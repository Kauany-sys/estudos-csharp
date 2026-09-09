using System;

namespace BibliotecaMatriz
{
    class Matriz
    {
        public static void LerMatriz(int[,] matriz)
        {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor na posição [{i},{j}]: ");
                matriz[i,j] = int.Parse(Console.ReadLine()!);
            }
        }
        }


        public static void MostrarMatriz(int[,] matriz)
        {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for(int i = 0; i< linhas; i++)
        {
            for(int j = 0; j < colunas ; j++)
            {
                Console.Write($"|{matriz[i,j],3}| ");
            }
            Console.WriteLine();
        }
        }

         public static void GerarMatriz(int[,] matriz)
        {
            Random random = new Random();
            int linhas = matriz.GetLength(0);
            int cols = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }
        }
    }

}