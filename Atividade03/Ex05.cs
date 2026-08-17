using System;

class Ex05
{
    // Função que verifica se n está no vetor
    static int BuscarElemento(int[] vetor, int n)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (n == vetor[i])
            {
                return i;
            }
        }
        return -1; 
    }

    static void Main()
    {
        int n;
        
        Console.Write("Defina o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[n];

        //sorteia elementos inteiros aleatórios no vetor
        Random rnd = new Random();
        for (int i = 0; i < vetor.Length; i++)
            vetor[i] = rnd.Next(1, 100);

        // o usuário digita o valor que deseja buscar
        Console.Write("Digite um número para buscar: ");
        int numeroBuscado = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("____Vetor sorteado____");
        for(int i =0; i < vetor.Length; i++)
            Console.Write($"|{vetor[i]}|");

        int posicao = BuscarElemento(vetor, numeroBuscado);

        if (posicao != -1)
            Console.WriteLine($"\nO número {numeroBuscado} está na posição {posicao}.");
        else
            Console.WriteLine($"\nO número {numeroBuscado} não está no vetor.");
    }
}