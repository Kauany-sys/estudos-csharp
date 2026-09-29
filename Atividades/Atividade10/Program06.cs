//Programa com menu de operações entre duas matrizes de valores reais
using System;

class Ex06
{
    //Função que gera uma matriz com valores reais entre 0 e 100
    static void GerarMatriz(double[,] matriz)
    {
        Random random = new Random();
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
                matriz[i,j] = Math.Round(random.NextDouble() * 100, 2);
        }
    }

    static void MostrarMatriz(double[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
                Console.Write($"|{matriz[i,j],7:F2}| ");

            Console.WriteLine();
        }
    }

    //Retorna uma terceira matriz com a soma das duas
    static double[,] SomarMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] resultado = new double[linhas,colunas];

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
                resultado[i,j] = matriz1[i,j] + matriz2[i,j];
        }

        return resultado;
    }

    //Retorna uma terceira matriz com a primeira subtraída da segunda
    static double[,] SubtrairMatrizes(double[,] matriz1, double[,] matriz2)
    {
        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);
        double[,] resultado = new double[linhas,colunas];

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
                resultado[i,j] = matriz2[i,j] - matriz1[i,j];
        }

        return resultado;
    }

    //Adiciona a constante na própria matriz
    static void AdicionarConstante(double[,] matriz, double constante)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for(int i = 0; i < linhas; i++)
        {
            for(int j = 0; j < colunas; j++)
                matriz[i,j] += constante;
        }
    }

    static void Main()
    {
        Console.Write("Digite o número de linhas: ");
        int linhas = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o número de colunas: ");
        int colunas = int.Parse(Console.ReadLine()!);

        double[,] matriz1 = new double[linhas,colunas];
        double[,] matriz2 = new double[linhas,colunas];

        GerarMatriz(matriz1);
        GerarMatriz(matriz2);

        string opcao;

        {
            Console.WriteLine();
            Console.WriteLine("___Menu___");
            Console.WriteLine("(a) Somar as duas matrizes");
            Console.WriteLine("(b) Subtrair a primeira matriz da segunda");
            Console.WriteLine("(c) Adicionar uma constante às duas matrizes");
            Console.WriteLine("(d) Imprimir as matrizes");
            Console.WriteLine("(e) Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine()!.ToLower();

            switch(opcao)
            {
                case "a":
                    Console.WriteLine("___Soma das matrizes___");
                    MostrarMatriz(SomarMatrizes(matriz1, matriz2));
                    break;

                case "b":
                    Console.WriteLine("___Segunda matriz - primeira matriz___");
                    MostrarMatriz(SubtrairMatrizes(matriz1, matriz2));
                    break;

                case "c":
                    Console.Write("Digite o valor da constante: ");
                    double constante = double.Parse(Console.ReadLine()!);

                    AdicionarConstante(matriz1, constante);
                    AdicionarConstante(matriz2, constante);
                    Console.WriteLine("Constante adicionada nas duas matrizes");
                    break;

                case "d":
                    Console.WriteLine("___Primeira matriz___");
                    MostrarMatriz(matriz1);
                    Console.WriteLine("___Segunda matriz___");
                    MostrarMatriz(matriz2);
                    break;

                case "e":
                    Console.WriteLine("Encerrando o programa");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        } while(opcao != "e");
    }
}