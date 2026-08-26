using System;

class Ex04
{
    static void Main()
    {
        string resposta = "SIM";
        string normalizada = resposta.ToLower();

        Console.WriteLine(normalizada);

        if (normalizada == "sim")
            Console.WriteLine("Resposta confirmada");

    }
}