using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS9.entity
{
    public class Usuario
    {
        public string nome;
        public string origem;
        public string? destino;
        public int? dia;

        public void Usuario(string _nome, string _origem){
            nome = _nome;
            origem = _origem;
        }




    }
}