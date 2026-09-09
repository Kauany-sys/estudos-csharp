using System;

class Ex02
{
    static double ObterMaiorNota(double[] notas) {
        double maiorNota = notas[0];

        for(int i = 1; i < notas.Length; i++)
        {
            if(notas[i] > maiorNota)
                maiorNota = notas[i];
        }
        return maiorNota;

    }

     static double ObterMenorNota(double[] notas) {
        double menorNota = notas[0];

        for(int i = 1; i < notas.Length; i++)
        {
            if(notas[i] > menorNota)
                menorNota = notas[i];
        }
        return menorNota;

    }

    static double SomarNotas (double[] notas)
    {
        double soma = 0;
        
        for(int i = 1; i < notas.Length; i++)
            soma += notas[i];

        return soma;
    }

    static double CalcularNotaFinal (double[] notas)
    {
        return SomarNotas(notas) - ObterMaiorNota(notas) - ObterMenorNota(notas);
    }
        


    static void Main()
    {
       double[] notas = new double[5];
       double resultado;

       Console.WriteLine("Digite as 5 notas ");

       for(int i = 0; i < notas.Length; i++) {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
       }

       resultado = CalcularNotaFinal(notas);
       Console.WriteLine($"Resultado final: {resultado:F2}");


    }
}