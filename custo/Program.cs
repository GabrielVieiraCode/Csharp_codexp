using System;

namespace custo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("digite o custo do produto");
            double valor = double.Parse(Console.ReadLine());
            double be= (valor*10)/100;
            double custo = valor + be;
            System.Console.WriteLine("produto R$"+custo);

        }
    }
}
