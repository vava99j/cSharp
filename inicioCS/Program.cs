using System;

namespace inicioCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dobro: {numero * 2}");

            Console.WriteLine("digite outro numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {numero + numero2}");

            bool par = (numero % 2 == 0);
            Console.WriteLine($"numero é par: {par}");

            bool n1maior = numero > numero2;
            Console.WriteLine($"numero 1 é maior: {n1maior}");

            Console.WriteLine("qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            bool maiorIdade = idade >= 18;
            Console.WriteLine($"maior idade? {maiorIdade}");

            double media = (numero + numero2) / 2.0;
            Console.WriteLine("media dos dois numeros: " + media);

            Console.WriteLine("digite um numero alto");
            int numAlto = int.Parse(Console.ReadLine());

            bool entre50e100 = (numAlto >= 50 && numAlto <= 100);
            Console.WriteLine($"num alto esta entre 50 e 100? {entre50e100}");

            double valorComDesconto = numAlto * 0.9;
            Console.WriteLine($"valor final com desconto de 10%: {valorComDesconto}");

            Console.WriteLine("digite um numero para verificar se é positivo, negativo ou 0");
            int numI = int.Parse(Console.ReadLine());

            if (numI > 0)
                Console.WriteLine("numero é positivo");
            else if (numI < 0)
                Console.WriteLine("numero é negativo");
            else
                Console.WriteLine("numero é 0");

            bool pdVotar = idade >= 16;
            Console.WriteLine($"pode votar? {pdVotar}");

            Console.WriteLine("Faça login(admin)");
            string login = Console.ReadLine();

            Console.WriteLine("Insira senha(1234)");
            int senha = int.Parse(Console.ReadLine());

            Console.WriteLine($"login correto? {login == "admin" && senha == 1234}");

            Console.WriteLine("insira outro numero");
            int numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"numero1: {numero}, numero 2: {numero2}, numero 3: {numero3}");

            if (numero > numero2 && numero > numero3)
            {
                Console.WriteLine("numero 1 é o maior");
            }
            else if (numero2 > numero && numero2 > numero3)
            {
                Console.WriteLine("numero 2 é o maior");
            }
            else if (numero3 > numero && numero3 > numero2)
            {
                Console.WriteLine("numero 3 é o maior");
            }
            else
            {
                Console.WriteLine("Os maiores números são iguais.");
            }

            Console.WriteLine("digite seu salario");
            double salario = double.Parse(Console.ReadLine());

            salario = salario > 2000 ? salario * 1.10 : salario * 1.20;
            Console.WriteLine($"novo salario: {salario}");

            Console.WriteLine("digite um ano");
            int ano = int.Parse(Console.ReadLine());

            bool anoBi = (ano % 4 == 0);
            Console.WriteLine($"{ano} bissexto? {anoBi}");

            Console.WriteLine("tem convite? (sim/nao)");
            string convite = Console.ReadLine();
            bool autFesta = convite == "sim" && idade >= 18;
            Console.WriteLine($"pode ir a festa? {autFesta}");
        }
    }
}