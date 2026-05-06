using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pojeto
{
    public abstract class Produto
    {
        public string nome {get; set;}
        public decimal preco_base{get; set;}

        public abstract decimal Calcular_preco_final();

        public virtual void Exibir_resumo(){
            Console.WriteLine($"Produto: {nome} \nPreço final: {Calcular_preco_final():f2}\n");        
        }

        public Produto(string n, decimal pb)
        {
            nome = n;
            preco_base= pb;
        }

    }
}