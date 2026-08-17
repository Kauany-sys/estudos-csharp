//Semana 2 - Aula ead - Vetores
using System;
using System.Collections.Specialized;
class ExAula
{
    //isso é uma função para ler um vetor
    static void LerVetor(int[] vetor)
    {
        Console.WriteLine("entre com os dados do vetor: ");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Array[{i}]:");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }
    }
    //essa função gera dados aleatórios em um vetor
    static void GerarVetor(int[] vetor)  
    {
        Random aleatorio = new Random();
        for(int i = 0 ; i < vetor.Length; i++)
            vetor[i] = aleatorio.Next(1,100);

    }
    //isso é uma função para exibir um vetor
    static void MostrarVetor(int[] vetor)
    {
        Console.WriteLine("Dados do vetor: ");
        for(int i = 0; i <vetor.Length; i++)
        {
            Console.Write($"|{vetor[i]}|");
        }
    }
    //isso é o código principal
    static void Main()
    {
        int[] Array = new int[5];
        GerarVetor(Array);
        MostrarVetor(Array);
       
    }
}
