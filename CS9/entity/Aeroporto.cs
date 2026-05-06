using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS9.entity
{
    public class Aeroporto
    {
        public string nome = "Congonhas";
        List<Voo> voos = new List<Voo>{
            Voo("london" , 5),
            Voo("london", 10),
            Voo("calabasas", 6)
        };

        List<Usuario> usuarios = new List<Usuario>{};
        void cadastro(Usuario user){
            usuarios.Add(user); 
            Console.WriteLine($"{user.nome} foi cadastrado no aeroporto de congonhas");      
        }


        public void ingressosUser(Usuario user){
            Console.WriteLine($"CADASTRO");
                cadastro(user);
        }

        public void ingressosAcom(Usuario user){
            Console.WriteLine($"ACOMPANHANTE");
                cadastro(user);
        }

        public void escolher_voo_user(Usuario user){
            for (var i = 0; i < voos.Count; i++)
            {
                 Console.WriteLine($"para {voos[i].destino} dia {voos[i].dia} - {i}");
            }
            Console.WriteLine($"escolha um voo"); 
            value = int.Parse(Console.ReadLine());
           if (value <= voos.Count && value >= voos.Count)
           {
                voos[value].addpass();
                user.dia = voos[value].dia;
                user.destino = voos[value].destino;
           }
        }

        public void add_acom_voo(Acompanhante acom){
            acom.destino = acom.resposanvel.destino;
            acom.dia = acom.resposanvel.dia;
        }
    }
}