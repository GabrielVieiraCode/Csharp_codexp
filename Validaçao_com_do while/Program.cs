using System;

namespace Validaçao_com_do_whille
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("validaçao com do while");
            string nome;
            string senha;
             
            do
            {
               System.Console.WriteLine("Digite seu nome");
                nome= Console.ReadLine();
                 



            }while(nome.Length<=1);

            do{
                System.Console.WriteLine("digite sua senha");
                senha = Console.ReadLine();

            }while(senha.Length<7);

        }
    }
}
