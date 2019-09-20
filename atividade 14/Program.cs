using System;

namespace atividade_14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o valor da sua primeira nota");
            int nota1 =int.Parse( Console.ReadLine());
            Console.WriteLine("Digite o valor da sua segunda nota");
            int nota2 =int.Parse( Console.ReadLine());

            System.Console.WriteLine("Digite a quantidade de faltas");
            float faltas = float.Parse(Console.ReadLine());

            float media = (nota1+nota2)/2;
            if(media>=50&&faltas<=30){
                System.Console.WriteLine($"Parabens {nome} voce foi aprovado");
            }
            else{
                System.Console.WriteLine($"{nome} Voce foi reprovado");
            }




        }
    }
}
