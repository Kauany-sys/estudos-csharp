using System;

class Ex01
{
    //função de soma dos elementos de um vetor
    static int SomaDosElementos(int[] vetor)
    {
        int soma = 0;
        for(int i = 0; i < vetor.Length; i++)
           soma = soma + vetor[i];
        
        return soma;
    }
    //código principal
    static void Main()
    {
        int n;
         Console.Write("Digite o tamanho do vetor desejado: ");
         n = int.Parse(Console.ReadLine());

        int [] vetor = new int[n];
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Elemento[{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"A soma dos elementos desse vetor é {SomaDosElementos(vetor)}" );

    }
}
