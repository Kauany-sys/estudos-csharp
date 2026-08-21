using System;
using BibliotecaFuncoes;

class Ex02
{

    static int contarImpares(int[] vetor)
    {
        int cont = 0 ;
        for ( int i = 0; i < vetor.Length; i++)
            if(vetor[i] % 2 == 1)
                cont++;
            //fim for

        return cont;
    }
    static void Main()
    {
        int n;
        Console.Write("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] Array = new int[n];
        BibliotecaVetor.gerarVetor(Array);
        BibliotecaVetor.mostrarVetor(Array);

        Console.WriteLine($"\nO vetor possui {contarImpares(Array)} número (s) ímpar (s).");
        Console.ReadKey();


    }
}