using System;

class Ex1064
{
    static void Main()
    {
        int cont = 0;
        double num, media = 0;

        for(int i=0; i < 6; i++)
        {
            num = double.Parse(Console.ReadLine());
            if (num > 0){
                Console.WriteLine(num);
                media = media + num ;
                cont++;
            }
        
        }
        Console.WriteLine("{} valores positivos", cont);
        Console.WriteLine("{:F2}", media);
    }

}