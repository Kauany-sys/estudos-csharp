using System;

class Ex08
{
    //Função que inverte a ordem do vetor
    static char[] inverterVetor(char[] vetor)
    {
        int tamanho = vetor.Length;
        char[] vetorInvertido = new char[tamanho];

        for(int i = 0; i < tamanho ; i++)
            vetorInvertido[i] = vetor[tamanho - 1 - i];

        return  vetorInvertido; 
        
    }
    static void Main()
    {
        char[] vetor = new char[5];

        //pede ao usuário para preencher o vetor
        Console.WriteLine("_____PREENCHA O VETOR COM CARACTERES_____");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"vetor[{i}]: ");
            vetor[i] = char.Parse(Console.ReadLine()!);
        }

        Console.Clear();

        //Exibe o vetor original
        Console.WriteLine("\n_____Vetor Original_____\n");
        for(int i = 0; i < vetor.Length; i ++)
            Console.Write($"|{vetor[i]}|");

        char[] vetorInvertido = inverterVetor(vetor);

        //Exibe o vetor invertido
        Console.WriteLine("\n_____Vetor invertido_____\n");
        for(int i = 0; i < vetor.Length; i ++)
            Console.Write($"|{vetorInvertido[i]}|");


    }
}