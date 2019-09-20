using System;

namespace atividade_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de passageiro do dia");
            float passageiros  = float.Parse(Console.ReadLine());
            float pass = 4.30f;
            float lucro = passageiros*pass;
            System.Console.WriteLine("seu lucro do dia foi: "+lucro);
            
        }
    }
}
