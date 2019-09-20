using System;

namespace atividade_19
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero do carfo para descobrir o salario");

            System.Console.WriteLine("(a) - Soma de 2 numeros");
            System.Console.WriteLine("(b) - subtraçao do primeiro pelo segundo");
            System.Console.WriteLine("(c) - subtraçao do segundo pelo primeiro");
            System.Console.WriteLine("(d) - multiplicaçao");
            System.Console.WriteLine("(e) - divisao do primeiro pelo segundo");
            System.Console.WriteLine("(e) - divisao do segundo peli primeiro");
            
            string resposta =  Console.ReadLine();
            

            switch(resposta){
                case "a":
                Console.WriteLine("Digite os dois valores");
                double nume = double.Parse(Console.ReadLine());
                double nume2 = double.Parse(Console.ReadLine());
                double r = nume+ nume2;
                System.Console.WriteLine($"resposta{r}");
                break;

                case "b":
                 Console.WriteLine("Digite os dois valores");
                double numero = double.Parse(Console.ReadLine());
                double numero2 = double.Parse(Console.ReadLine());
                double re = numero - numero2;
                System.Console.WriteLine($"resposta{re}");
                break;

                case "c":
                 Console.WriteLine("Digite os dois valores");
                double numen = double.Parse(Console.ReadLine());
                double numen2 = double.Parse(Console.ReadLine());
                double res = numen2- numen;
                System.Console.WriteLine($"resposta{res}");
                break;

                case "d":
                 Console.WriteLine("Digite os dois valores");
                 double numem = double.Parse(Console.ReadLine());
                 double numem2 = double.Parse(Console.ReadLine());
                 double resp = numem*2;
                 double mult = numem2*2;
                System.Console.WriteLine($"resposta: primeira multiplicaçao:{resp};segunda multiplicaçao:{mult}");
                break;

                case "e":
                 Console.WriteLine("Digite os dois valores");
                double numi = double.Parse(Console.ReadLine());
                double numi2 = double.Parse(Console.ReadLine());
                double respo = numi/numi2;
                System.Console.WriteLine($"resposta{respo}");
                break;

                 case "f":
                 Console.WriteLine("Digite os dois valores");
                double numin = int.Parse(Console.ReadLine());
                double numin2 = int.Parse(Console.ReadLine());
                double respos = numin2/numin;
                System.Console.WriteLine($"resposta{respos}");
                break;

                default:
                Console.WriteLine("Digite uma letra entre A e F");
               break;

            }
        }
    }
}
