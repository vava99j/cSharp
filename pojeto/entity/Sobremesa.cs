using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pojeto
{
    public class Sobremesa : Produto , ID_desconto
    {
           public Sobremesa(string nome , decimal preco_base) : base(nome, preco_base){

        }
        public decimal Aplicar_desconto(){
            return 0.90m;
        }
        public override decimal Calcular_preco_final(){
            return preco_base *= Aplicar_desconto();
        }

        public override void Exibir_resumo(){
            Console.WriteLine($"Tipo: Sobremesa");
            base.Exibir_resumo();  
        }
    }
}