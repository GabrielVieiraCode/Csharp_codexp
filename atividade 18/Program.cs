using System;

namespace atividade_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cargos com switch");
            System.Console.WriteLine("Digite o numero do carfo para descobrir o salario");

            System.Console.WriteLine("(1) - diretor");
            System.Console.WriteLine("(2) - gerente");
            System.Console.WriteLine("(3) - professor");
            System.Console.WriteLine("(4) - coordenador");
            System.Console.WriteLine("(5) - diretor");
            
            string resposta =  Console.ReadLine();

            switch(resposta){
                case "1":
                Console.WriteLine("O slario de diretor pe de R$18.000,00");
                break;

                case "2":
                Console.WriteLine("O salario de gerente é de R$ 12.000,00");
                break;

                case "3":
                Console.WriteLine("O salario de professor é de R$ 12.000,00");
                break;

                case "4":
                Console.WriteLine("O salario de coordenador é de R$ 12.000,00");
                break;

                case "5":
                Console.WriteLine("O salario de atendente é de R$ 12.000,00");
                break;

                default:
                Console.WriteLine("Digite um valor entre 1 e 5");
               break;

            }

        }
}
}
