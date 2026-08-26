using System;

class Ex06
{
    static void Main()
    {
       string nome1 = "Ana";
string nome2 = "Ana";
int resultado = string.Compare(nome1, nome2);

Console.WriteLine(resultado);

if (resultado == 0)
    Console.WriteLine("Textos iguais");
else if (resultado < 0)
    Console.WriteLine("O primeiro vem antes");
else
    Console.WriteLine("O primeiro vem depois");

    }
}