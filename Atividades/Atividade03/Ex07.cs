using System;
class Ex07
{

    static int ContarElemento (int[] vetor, int NumeroBuscado)
    {
        int cont = 0;
        for(int i = 0; i < vetor.Length ; i++)
        {
            if (vetor[i] == NumeroBuscado)
                cont++;
        }
        return cont;
    }
    static void Main()
    {
        int tamanho, numeroBuscado;
        
        //o usuário define o tamanho do vetor
        Console.Write("Defina o tamanho do vetor: ");
        tamanho = int.Parse(Console.ReadLine()!);
        int[] vetor = new int[tamanho];

        //sorteia elementos inteiros aleatórios no vetor
        Random rnd = new Random();
        for (int i = 0; i < vetor.Length; i++)
            vetor[i] = rnd.Next(1,20);

        Console.Write("Digite o número que deseja procurar: ");
        numeroBuscado = int.Parse(Console.ReadLine());

        //Exibe o vetor
        Console.WriteLine("_____Vetor Criado_____");
        for(int i = 0; i < vetor.Length; i ++)
            Console.Write($"|{vetor[i]}|");

        Console.WriteLine($"\nO número {numeroBuscado} aparece {ContarElemento(vetor, numeroBuscado)} vezes.");
        
        

        

        

    }
}