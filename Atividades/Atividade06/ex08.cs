using System;

class Ex08
{
    static void Main()
    {
        string texto = "Exemplo de string";

        string parte1 = texto.Substring(8);
        string parte2 = texto.Substring(0, 7);

        Console.WriteLine(parte1);
        Console.WriteLine(parte2);

    }
}