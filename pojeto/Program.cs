using System;
namespace pojeto;

class Program
{
    static void Main(string[] args)
    {
        
        List<Produto> produtos =  new List<Produto>
        {
        new Lanche("hamburguer" , 25m),
        new Bebida("Sucuzinho", 5m),
        new Sobremesa("Pavê", 10m),
        };
decimal total = 0;
        foreach (Produto produto in produtos)
        {
            total += produto.Calcular_preco_final();
            produto.Exibir_resumo();
        }
        Console.WriteLine($"Total: R${total}");
        
    }
}
