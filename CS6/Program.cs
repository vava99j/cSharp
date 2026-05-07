using System;

namespace cSharp6;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("taubada");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i * num);
        }
        int numDw = 0;
        do
        {
            Console.WriteLine(numDw += 1);
        } while (numDw != 5);


        Console.WriteLine("5 somas");
        int num1 = 0;
        for (int i = 1; i <= 5; i++)
        {
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 += num1);
        }


        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);

            }
        }



        Console.WriteLine("senha (1234)");
        int senha = 0;
        do
        {
            senha = int.Parse(Console.ReadLine());
        } while (senha != 1234);

        string opcao = "";
        do
        {
            Console.WriteLine("1 fica e 2 sai");
            opcao = Console.ReadLine();
        } while (opcao != "2");

        Console.WriteLine("4somas e media final");
        int num4 = 0;
        for (int i = 1; i <= 4; i++)
        {
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine(num4 += num4);
        }
        Console.WriteLine(num4 /= 4);

        Console.WriteLine("d 5 qual maior");
         int num6 = 0;
        List<int> numMaior = new List<int>{};
        for (int i = 1; i <= 5; i++)
        {
             num6 = int.Parse(Console.ReadLine());
            numMaior.Add(num6);
        }
        Console.WriteLine(numMaior.Max()
        );


        int num2 = 0;
        int _count = 0;
        do
        {
            Console.WriteLine("0 sai");
            num2 = int.Parse(Console.ReadLine());
            if (num2 != 0)
            {
                _count += 1;

            }
        } while (num2 != 0);
        Console.WriteLine($"foram escritos {_count} numeros");


        int num3 = 0;
        do
        {
            Console.WriteLine("NUM QUALQUER (negativo sai do loop)");
            num3 = int.Parse(Console.ReadLine());

        } while (num2 > 0);
        Console.WriteLine("ALERTA DE NUMERO NEGATIVO");

int soma = 0;

List<int> numForeach = new List<int> { 1, 99, 88, 77, 66 };
        foreach (var item in numForeach)
        {
            soma += item;
            Console.WriteLine(item);
        }

int soma2 =0;

List<int> numNotas = new List<int> { 1, 99, 88, 77, 66 };
  foreach (var item in numNotas)
        {
            soma2 += item;
            Console.WriteLine(item);
        }
            Console.WriteLine(soma2 /= 5);


    }
}

