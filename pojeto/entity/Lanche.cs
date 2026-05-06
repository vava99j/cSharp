using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pojeto
{
    public class Lanche : Produto
    {
        public Lanche(string nome , decimal preco_base) : base(nome, preco_base){

        }
        private decimal taxa_embalagem = 2m;
        public override decimal Calcular_preco_final(){
            return preco_base += taxa_embalagem;
        }

        public virtual void Exibir_resumo(){
            Console.WriteLine($"Tipo: Lanche");
            base.Exibir_resumo();  
        }
    }
}