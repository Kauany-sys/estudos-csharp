//Programa Caçadores de Mito: verifica se um raio caiu duas vezes no mesmo lugar
using System;

class Ex08
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        //Cada posição da matriz é um quadrante (X e Y vão de 0 a 500)
        bool[,] quadrantes = new bool[501,501];
        int repetido = 0;

        for(int i = 0; i < n; i++)
        {
            string[] partes = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(partes[0]);
            int y = int.Parse(partes[1]);

            //Se o quadrante já foi marcado, o raio caiu no mesmo lugar
            if(quadrantes[x,y])
                repetido = 1;

            quadrantes[x,y] = true;
        }

        Console.WriteLine(repetido);
    }
}