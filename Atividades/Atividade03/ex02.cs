using System;
using System.Collections.Specialized;

class Ex02
{
    //Função que conta a quantidade de números ímpares no vetor.
    static int  ContarImpares (int[] vetor)
    {
        int  impares = 0;
        for(int i = 0; i < vetor.Length ; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                impares = impares + 1;
            }
        }
        return impares;
    }

    static void Main()
    {
        int n ;

        Console.Write("Digite o tamanho do vetor Desejado: ");
        n = int.Parse(Console.ReadLine());

        int [] vetor = new int[n];

        Console.WriteLine("____Digite os elementos do vetor____");

        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"vetor[{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Esse vetor possui {ContarImpares(vetor)} números ímpares.");
        




        


    }
}