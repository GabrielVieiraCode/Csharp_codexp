using System;

namespace atividade_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digie o seu salario");
            float salario = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o valor de suas dividas");
            float div = float.Parse(Console.ReadLine());
            float sobra = salario - div;
            System.Console.WriteLine("ira sobra do seus salario: "+sobra);
        }
    }
}
