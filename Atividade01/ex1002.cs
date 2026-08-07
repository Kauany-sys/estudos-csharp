using System;

class Ex1002
{
    static void Main()
    {
        double raio, area;


       raio = double.Parse(Console.ReadLine());
        area = 3.14159 * Math.Pow(raio,2);
        Console.WriteLine("A={0:F4}",area);

    }
}
