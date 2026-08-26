using System;

class Ex05
{
    static void Main()
    {
        char[] letras = { 'c', 'A', 'b', 'B', 'a' };
        Array.Sort(letras);

        Console.WriteLine(new string(letras));

    }
}