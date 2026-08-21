using System;

class Ex03
{
    //função que retorna o maior elemento em um vetor de reais
    static double MaiorElemento (double[] vetor)
    {
        double maior = 0;

         for(int i = 0; i < vetor.Length; i++)
        {
            if(vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }

    static void Main()
    {
        int n;
        double maior;

        Console.Write("Defina o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine()!);
        double[] vetor = new double[n];

        //define valores double aleatórios para o vetor
        Random rnd = new Random();
        for(int i = 0 ; i < vetor.Length; i++)
            vetor[i] = rnd.NextDouble();

        maior = MaiorElemento(vetor);

        for(int i = 0; i < vetor.Length; i++)
            Console.Write($"|{vetor[i]:F2}|");
        Console.Write($" O maior número do vetor apresentado é {maior:F2}");

        



    }
}