using System;
using BibliotecaFuncoes;

class Ex01
{
    static void Main()
    {
        int[] meuArray = new int[10];
        BibliotecaVetor.lerVetor(meuArray);
        BibliotecaVetor.mostrarVetor(meuArray);
        Console.ReadKey();
    }
}