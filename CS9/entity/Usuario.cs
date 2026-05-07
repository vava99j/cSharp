using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS9
{
    public class Usuario
    {
        public string nome;
        public string origem;
        public string senha;
        public string? destino;
        public int? dia;

        public Usuario(string _nome, string _origem, string _senha){
            nome = _nome;
            origem = _origem;
            senha = _senha;
        }




    }
}