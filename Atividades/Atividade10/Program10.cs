//Programa que calcula a área do mar coberta por pelo menos uma rede de pesca
using System;

class Ex10
{
    //Função que marca os pontos cobertos por cada rede e conta a área total
    static int CalcularArea(int[,] redes, int maiorX, int maiorY)
    {
        int n = redes.GetLength(0);
        bool[,] mar = new bool[maiorX + 1, maiorY + 1];
        int area = 0;

        for(int k = 0; k < n; k++)
        {
            for(int i = redes[k,0]; i <= redes[k,1]; i++)
            {
                for(int j = redes[k,2]; j <= redes[k,3]; j++)
                {
                    //Só conta o ponto se nenhuma rede passou por ele antes
                    if(!mar[i,j])
                    {
                        mar[i,j] = true;
                        area++;
                    }
                }
            }
        }

        return area;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);

        //Cada linha guarda Xi, Xf, Yi e Yf de uma rede
        int[,] redes = new int[n,4];
        int maiorX = 0;
        int maiorY = 0;

        for(int i = 0; i < n; i++)
        {
            string[] partes = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for(int j = 0; j < 4; j++)
                redes[i,j] = int.Parse(partes[j]);

            if(redes[i,1] > maiorX)
                maiorX = redes[i,1];

            if(redes[i,3] > maiorY)
                maiorY = redes[i,3];
        }

        Console.WriteLine(CalcularArea(redes, maiorX, maiorY));
    }
}