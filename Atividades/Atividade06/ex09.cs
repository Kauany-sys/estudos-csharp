using System;

class Ex09
{
    static void Main()
    {
        Console.Write("Digite o primeiro texto: ");
        string texto1 = Console.ReadLine() ?? "";
        Console.Write("Digite o segundo texto: ");
        string texto2 = Console.ReadLine() ?? "";

        Console.WriteLine("Tamanho do texto 1: " + texto1.Length);
        Console.WriteLine("Tamanho do texto 2: " + texto2.Length);
        
        string textoMaiusculas1 = texto1.ToUpper();
        string textoMaiusculas2 = texto2.ToUpper();

        Console.WriteLine(textoMaiusculas1);
        Console.WriteLine(textoMaiusculas2);

        int resultado = string.Compare(textoMaiusculas1, textoMaiusculas2);

        if(resultado == 0)
            Console.WriteLine("Os textos são equivalentes");
        else 
            Console.WriteLine("Os textos não são equivalentes.");

    }
}