using System;

class Ex01
{

    static void LerVetor(int[] vetor)
    {
        Console.WriteLine("entre com os dados do vetor: ");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Array[{i}]:");
            vetor[i] = int.Parse(Console.ReadLine()!);
        }
    }
    static void BuscarMenorNumero(int[] vetor)
    {
        int menor = vetor[0];
        int posicao = 0;

        for(int i = 0; i < vetor.Length ; i++)
        {
            if(vetor[i] < menor){
                menor = vetor[i];
                posicao = i;
            }
        }
        Console.WriteLine($"Menor valor: {menor}");
        Console.WriteLine($"Posição: {posicao}");

    }
    static void Main()
    {
        //O usuário define o tamanho do vetor
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[n];

        LerVetor(vetor);
        BuscarMenorNumero(vetor);

    }
}
