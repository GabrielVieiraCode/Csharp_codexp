using System;

namespace atividade_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
             System.Console.WriteLine("Digite o codigo do cargo");
             Console.ForegroundColor = ConsoleColor.Red;

            System.Console.WriteLine("(1) - escritura");
            System.Console.WriteLine("(2) - secretaria");
            System.Console.WriteLine("(3) - caixa");
            System.Console.WriteLine("(4) - gerente");
            System.Console.WriteLine("(5) - diretor");
            string cod = Console.ReadLine();
            
            switch(cod){
                case "1":
                System.Console.WriteLine("digite seu salario");
                float s = float.Parse(Console.ReadLine());
                float p = s*0.5f;
                float pt = p+s;
                System.Console.WriteLine($"seu nome é{nome}/n seu aumento sera de{p} mais o seu salario ficara {pt}");

                break;

                case "2":
                 System.Console.WriteLine("digite seu salario");
                float s2 = float.Parse(Console.ReadLine());
                float p2 = s2*0.3f;
                float pt2 = p2+s2;
                System.Console.WriteLine($"seu nome é{nome}/n seu aumento sera de{p2} mais o seu salario ficara {pt2}");
                break;

                case "3":
                System.Console.WriteLine("digite seu salario");
                float s3 = float.Parse(Console.ReadLine());
                float p3 = s3*0.2f;
                float pt3 = p3+s3;
                System.Console.WriteLine($"seu nome é{nome}/n seu aumento sera de{p3} mais o seu salario ficara {pt3}");
                break;

                case "4":
                System.Console.WriteLine("digite seu salario");
                float s4 = float.Parse(Console.ReadLine());
                float p4 = s4*0.1f;
                float pt4 = p4+s4;
                Console.ForegroundColor = ConsoleColor.Blue;

                System.Console.WriteLine($"seu nome é{nome} seu aumento sera de{p4} mais o seu salario ficara {pt4}");
                break;

                case "5":
                System.Console.WriteLine("Seu cargo nao permite aumento ");
                
                break;

                default:
                Console.WriteLine("Digite um codigo entre 1 e 5");
               break;
           

        }
    }
}
 }
