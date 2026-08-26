using System;

class Ex08
{
    //Função que gera o vetor complementar de bases
    static char[] gerarComplementar(char[] vetor)
    {
        int tamanho = vetor.Length;
        char[] vetorComplementar = new char[tamanho];

        for(int i = 0; i < tamanho; i++)
        {
            switch(vetor[i])
            {
                case 'A':
                    vetorComplementar[i] = 'T';
                    break;
                case 'T':
                    vetorComplementar[i] = 'A';
                    break;
                case 'C':
                    vetorComplementar[i] = 'G';
                    break;
                case 'G':
                    vetorComplementar[i] = 'C';
                    break;
                default:
                    vetorComplementar[i] = '?';
                    break;
            }
        }

        return vetorComplementar;
    }

    static void Main()
    {
        Console.Write("Digite o tamanho da fita de DNA (max 50): ");
        int tamanho = int.Parse(Console.ReadLine()!);

        char[] dna = new char[tamanho];

        //pede ao usuário para preencher o vetor com as bases
        Console.WriteLine("_____PREENCHA O VETOR COM AS BASES (A, T, C, G)_____");
        for(int i = 0; i < dna.Length; i++)
        {
            Console.Write($"dna[{i}]: ");
            dna[i] = char.ToUpper(char.Parse(Console.ReadLine()!));
        }

        Console.Clear();

        //Exibe a fita original
        Console.WriteLine("\n_____Fita Original_____\n");
        for(int i = 0; i < dna.Length; i++)
            Console.Write($"|{dna[i]}|");

        char[] dnaComplementar = gerarComplementar(dna);

        //Exibe a fita complementar
        Console.WriteLine("\n_____Fita Complementar_____\n");
        for(int i = 0; i < dnaComplementar.Length; i++)
            Console.Write($"|{dnaComplementar[i]}|");
    }
}