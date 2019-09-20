using System;

namespace ATIVIDADE26
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
             do{
            System.Console.WriteLine("digite seu email");
             email= Console.ReadLine();

        }while(!email.Contains("@")||!email.Contains("."));
        string senha;
        do{
            System.Console.WriteLine("digite sua senha");
            senha = Console.ReadLine();

        }while(senha.Length<=6);


               
            }

        }
    }

