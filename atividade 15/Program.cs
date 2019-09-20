using System;

namespace atividade_15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
        

            if(idade<18||idade>=60){
                System.Console.WriteLine($"{nome}Voce tem direito a meia");
            }
            else{
                System.Console.WriteLine($"`{nome}Voce nao tem direito ao a meia");
            }
        }
    }
}
