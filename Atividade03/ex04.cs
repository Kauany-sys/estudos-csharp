using System;
using System.Runtime.InteropServices;

class Ex04
{
    static double MenorElemento(double[] vetor)
    {
        double menor = vetor[0];

        for(int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }
        return menor;
    }
    static void Main()
    {
        int n;

        //O usuário define o tamanho e preenche os elementos do vetor.
        Console.Write("Digite o tamanho do vetor desejado: ");
        n = int.Parse(Console.ReadLine()!);
        double [] vetor = new double[n];
        Console.WriteLine("Preencha com números reais: ");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Elemento[{i}]: ");
            vetor[i] = double.Parse(Console.ReadLine()!);
        }
    
        //exibe o vetor e indica o menor elemento
        for(int i = 0 ; i < vetor.Length ; i++)
            Console.Write($"|{vetor[i]}| ");
        
        Console.WriteLine($"\nO menor elemento do vetor apresentado é {MenorElemento(vetor)}");

    }
}