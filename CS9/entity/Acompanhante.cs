using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS9
{
    public class Acompanhante : Usuario
    {
        public Usuario resposanvel;

        public Acompanhante(string _nome, string _origem,string _senha, Usuario _responsavel) : base(_nome, _origem, _senha){
            resposanvel = _responsavel;
        }

    }
}