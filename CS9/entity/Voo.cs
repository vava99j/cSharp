using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS9
{
    public class Voo
    {
        public string destino { get; set; }
        public int dia { get; set; }



     
       public Voo(string _destino, int _dia){
        destino = _destino;
        dia = _dia;
       }

    }
}