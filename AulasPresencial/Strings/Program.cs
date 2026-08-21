using System;
class Program
{
    static void Main()
    {
        string texto = "HELLO";
        Console.WriteLine(texto[0]);
        Console.WriteLine(texto[4]);
        Console.WriteLine((int)texto[0]);

        for(int i = 0; i < texto.Length; i++)
            Console.WriteLine(texto[i]);
        

    }
}