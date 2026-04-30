using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharp7;

class Program
{
    static void Main(string[] args)
    {
        int[] notaSala = { 10, 20, 30, 40, 50 };
        string[] alunos = { "jorge", "gauchinha", "mar" };

       Console.WriteLine( notasCalculo(notaSala, alunos));

    }

    static string notasCalculo(int[] notas, string[] alunos)
    {
        int soma = 0;

        foreach (var item in notas)
        {
            soma += item;
            Console.WriteLine($"Nota: {item}");
        }

        double media = (double)soma / notas.Length;
        Console.WriteLine($"Média da sala: {media:F2}");

        Console.WriteLine("\nLista de Alunos:");
        foreach (var item in alunos)
        {
            Console.WriteLine(item);
        }
        return soma >= 6 ? "PASSARAM" : "REPROVADOS";
    }
}