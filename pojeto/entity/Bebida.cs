using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pojeto
{
    public class Bebida : Produto
    {
          public Bebida(string nome , decimal preco_base) : base(nome, preco_base){

        }
        public override decimal Calcular_preco_final(){
            return preco_base;
        }

        public void Exibir_resumo(){
            Console.WriteLine($"Tipo: Bebida");
            base.Exibir_resumo();  
        }
    }
}