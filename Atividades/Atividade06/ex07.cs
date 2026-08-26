using System;

class Ex07
{
    static void Main()
    {
        string nome = "Ana";
        string sobrenome = "Silva";

        string completo1 = nome + " " + sobrenome;
        string completo2 = string.Concat(nome, " ", sobrenome);

        Console.WriteLine(completo1);
        Console.WriteLine(completo2);

    }
}