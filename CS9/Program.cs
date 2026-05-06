using System;
namespace CS9;

class Program
{
    static void Main(string[] args)
    {
    Aeroporto a1 = new Aeroporto();
    Usuario user1 = new Usuario{
        nome = "jorge",
        origem = "brasil"
    };
    Acompahante acom1 = new Acompahante{
        nome = "gustavo",
        OperatingSystem = "argentina",
        responsavel = user1
    };
    a1.ingressosUser(user1);
    a1.escolher_voo_user(user);
    a1.ingressosAcom(acom1);
    a1.add_acom_voo(acom1);

    }
}
