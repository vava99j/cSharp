using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS9
{
    public class Aeroporto
    {
        public string nome = "Congonhas";
        public Aeroporto() { }
        List<Voo> voos = new List<Voo>{
            new Voo("london" , 5),
            new Voo("london", 10),
            new Voo("calabasas", 6)
        };

        List<Usuario> usuarios = new List<Usuario> { };
        void cadastro(Usuario user)
        {
            usuarios.Add(user);
            Console.WriteLine($"{user.nome} foi cadastrado no aeroporto de congonhas");
        }


        public void ingressosUser(Usuario user)
        {
            Console.WriteLine($"CADASTRO");
            cadastro(user);
        }

        public void ingressosAcom(Acompanhante acom)
        {
            Console.WriteLine($"ACOMPANHANTE");
            if (acom.destino == null && acom.dia == null)
            {
                cadastro(acom);

            }
        }

        public bool escolher_voo_user(Usuario user)
        {
Console.WriteLine($"senha:");
string senha = Console.ReadLine()!;
if (senha != user.senha)
{
    return false;
}else
{
    

            for (var i = 0; i < voos.Count; i++)
            {
                Console.WriteLine($"para {voos[i].destino} dia {voos[i].dia} - {i}");
            }
            Console.WriteLine($"escolha um voo");

            int value = int.Parse(Console.ReadLine()!);
        if (value > 0 && value <= voos.Count)
            {
                user.dia = voos[value].dia;
                user.destino = voos[value].destino;
                 if (user.destino != null && user.dia != null)
            { Console.WriteLine($"voo para {user.destino} dia{user.dia} para {user.nome} "); };

            }
return true;
}


           
        }

        public void add_acom_voo(Acompanhante acom)
        {
            acom.destino = acom.resposanvel.destino;
            acom.dia = acom.resposanvel.dia;
            Console.WriteLine($"voo {acom.destino} {acom.dia} para {acom.nome} ");

        }
    }
}