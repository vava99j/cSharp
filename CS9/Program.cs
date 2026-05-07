using System;
namespace CS9
{

    class Program
    {
        static void Main(string[] args)
        {
            Aeroporto a1 = new Aeroporto { };
            Usuario user1 = new Usuario("jorge", "Brasil", "123456");
            Acompanhante acom1 = new Acompanhante("gustavo", "Argentina", user1.senha, user1);
            a1.ingressosUser(user1);
            if (a1.escolher_voo_user(user1))
            {
                a1.ingressosAcom(acom1);
                a1.add_acom_voo(acom1);
            }


        }
    }
}