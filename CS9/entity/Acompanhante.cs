using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS9.entity
{
    public class Acompanhante : Usuario
    {
        public Usuario resposanvel;

        public Acompanhante(string nome, string origem, Usuario _resposanvel){
            nome = _nome;
            origem = _origem;
            resposanvel = _responsavel;
        }

    }
}