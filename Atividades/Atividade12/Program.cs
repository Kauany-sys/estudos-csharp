using System;
using BibliotecaMatriz;
using System.IO;
class Program01
{
    public static int[,] carregarMatriz(string caminhoArquivo)
{
    string[] linhas = File.ReadAllLines(caminhoArquivo);
    int numLinhas = linhas.Length;
    int numColunas = linhas[0].Split(',').Length;

    int[,] matriz = new int[numLinhas, numColunas];

    for (int i = 0; i < numLinhas; i++)
    {
        string[] valores = linhas[i].Split(',');
        for (int j = 0; j < numColunas; j++)
        {
            matriz[i, j] = int.Parse(valores[j]);
        }
    }
    return matriz;
}

    static void Main()
    {
        int[,] MatrizOcorrencias = carregarMatriz("ocorrencias.csv");
        
        Matriz.mostrarMatriz(MatrizOcorrencias);

    }
}
