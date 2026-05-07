using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharp7;

    class Program
    {
        static void Main(string[] args)
        {
            Atv1();
            Atv2();
            Atv3("Oi", 3);
            Atv4();
            Atv5();
            Atv6();
            Atv7("arara");
            Atv7("casa");
            Atv8();
            Atv9();
            Atv10();
            Atv11();
            Atv12();
            Extra();
        }


        static void Atv1()
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine() ?? "";
            
            int contador = 0;
            foreach (char letra in palavra)
            {
                if (letra == 'a' || letra == 'A')
                {
                    contador++;
                }
            }
            Console.WriteLine($"A letra 'a' aparece {contador} vez(es).");
        }

        static void Atv2()
        {
            string[] nomes = { "Ana", "Bruno", "Carlos", "Duda" };
            
            Console.WriteLine("Nomes de trás pra frente:");
            for (int i = nomes.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        static void Atv3(string palavra, int vezes)
        {
            for (int i = 0; i < vezes; i++)
            {
                Console.Write(palavra + " ");
            }
        }


        static void Atv4()
        {
            int[] numeros = { 0, 5, 0, 10, 0, 20 };
            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    numeros[i] = 1;
                }
            }
            
            Console.WriteLine("Array substituindo 0 por 1: " + string.Join(", ", numeros));
        }

        static void Atv5()
        {
            int[] numeros = { 10, 20, 30, 40, 50 };
            
            Console.Write("Digite um número para remover (simulado): ");
            if(int.TryParse(Console.ReadLine(), out int remover))
            {
                Console.Write("Valores restantes: ");
                foreach (int num in numeros)
                {
                    if (num != remover)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }

        static void Atv6()
        {
            string[] nomes = { "Lucas", "Mariana", "Pedro", "Julia", "Marcos" };
            
            Console.Write("Digite um nome para buscar: ");
            string busca = Console.ReadLine() ?? "";
            
            int posicao = -1;
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
                {
                    posicao = i;
                    break; 
                }
            }

            if (posicao != -1)
                Console.WriteLine($"Nome encontrado na posição {posicao}.");
            else
                Console.WriteLine("Nome não encontrado.");
        }


        static void Atv7(string palavra)
        {
            string invertida = "";
            
            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                invertida += palavra[i];
            }

            bool ehPalindromo = (palavra == invertida);
            Console.WriteLine($"{palavra} é palíndromo? {ehPalindromo}");
        }

        static void Atv8()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6 };
            
        
            int[] pares = new int[6];
            int[] impares = new int[6];
            int contPares = 0, contImpares = 0;

            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                {
                    pares[contPares] = num;
                    contPares++;
                }
                else
                {
                    impares[contImpares] = num;
                    contImpares++;
                }
            }
            
            Console.WriteLine($"Temos {contPares} números pares e {contImpares} ímpares separados nos arrays.");
        }

        static void Atv9()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] arrayJunto = new int[6];

            for (int i = 0; i < array1.Length; i++)
                arrayJunto[i] = array1[i];

            for (int i = 0; i < array2.Length; i++)
                arrayJunto[i + 3] = array2[i];

            Console.WriteLine("Array junto: [" + string.Join(", ", arrayJunto) + "]");
        }


        static void Atv10()
        {
            string[] ranking = { "Lugar1", "Lugar2", "Lugar3", "Lugar4", "Lugar5" };
            
            Console.WriteLine($"Primeiro: {ranking[0]} | Último: {ranking[4]}");
            
            string temp = ranking[0];
            ranking[0] = ranking[4];
            ranking[4] = temp;
            
            Console.WriteLine("Após a troca:");
            Console.WriteLine($"Primeiro: {ranking[0]} | Último: {ranking[4]}");
        }

        static void Atv11()
        {
            Console.Write("Digite uma palavra para codificar: ");
            string palavra = Console.ReadLine()?.ToLower() ?? "";
            
            string codigoSecreto = "";
            foreach (char letra in palavra)
            {
                switch (letra)
                {
                    case 'a': codigoSecreto += "1"; break;
                    case 'e': codigoSecreto += "2"; break;
                    case 'i': codigoSecreto += "3"; break;
                    case 'o': codigoSecreto += "4"; break;
                    case 'u': codigoSecreto += "5"; break;
                    default: codigoSecreto += letra; break;
                }
            }
            Console.WriteLine($"Código: {codigoSecreto}");
        }

        static void Atv12()
        {
            string[] produtos = { "Mouse", "Teclado", "Monitor", "Fone", "Cadeira" };
            
            Console.Write("Digite o produto que deseja buscar: ");
            string busca = Console.ReadLine() ?? "";
            
            bool encontrado = false;
            for (int i = 0; i < produtos.Length; i++)
            {
                if (produtos[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break;
                }
            }
            
            Console.WriteLine(encontrado ? "Encontrado" : "Não encontrado");
        }


        static void Extra()
        {
            List<string> listaNomes = new List<string>();
            
            while (true)
            {
                Console.WriteLine("\n1 - Adicionar nome | 2 - Remover nome | 3 - Sair");
                string opcao = Console.ReadLine() ?? "";

                if (opcao == "1")
                {
                    Console.Write("Digite o nome para adicionar: ");
                    string nome = Console.ReadLine() ?? "";
                    
                    if (!listaNomes.Contains(nome))
                    {
                        listaNomes.Add(nome);
                        Console.WriteLine("Nome adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Esse nome já existe na lista.");
                    }
                }
                else if (opcao == "2")
                {
                    Console.Write("Digite o nome para remover: ");
                    string nome = Console.ReadLine() ?? "";
                    
                    if (listaNomes.Remove(nome))
                        Console.WriteLine("Nome removido.");
                    else
                        Console.WriteLine("Nome não encontrado.");
                }
                else if (opcao == "3")
                {
                    break; 
                }

                Console.WriteLine($"Total de itens na lista: {listaNomes.Count}");
            }
        }
    }
