using System;
class Ex06
{
    //Função que cria um terceiro vetor a partir da multiplicação do primeiro com o segundo. 
    static int[] criarNovoVetor (int[] primeiroVetor , int[]segundoVetor)
    {
       int[] terceiroVetor = new int[primeiroVetor.Length];
       int n = primeiroVetor.Length;

       for(int i = 0 ; i < n; i++)
            terceiroVetor[i] = primeiroVetor[i] * segundoVetor[i];
        
        return terceiroVetor;
    }
    
    static void Main()
    {
        int[] primeiroVetor = new int[5];
        int[] segundoVetor = new int[5];

        // O usuário preenche os vetores
        Console.WriteLine("___Preencha o primeiro Vetor___");
        for(int i = 0; i < primeiroVetor.Length ; i++)
            primeiroVetor[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("___Preencha o segundo Vetor___");
        for(int i = 0; i < primeiroVetor.Length ; i++)
            segundoVetor[i] = int.Parse(Console.ReadLine());

        //Exibe o terceiro vetor
        int[] terceiroVetor = criarNovoVetor(primeiroVetor, segundoVetor);
        Console.WriteLine("Terceiro vetor criado da multiplicação do primeiro com o segundo:");
        for(int i = 0; i < terceiroVetor.Length; i++)
            Console.Write($"|{terceiroVetor[i]}|");

    }
}