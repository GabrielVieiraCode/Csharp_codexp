using System;

namespace atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu salario");
            float sal = float.Parse(Console.ReadLine());
            System.Console.WriteLine("digite a quantiade de suas vendas");
            float venda = float.Parse(Console.ReadLine());
            float contatotal = (venda*5)/100;
            float saltotal  = contatotal+sal;
            System.Console.WriteLine("voce ira receber "+saltotal);

        }
    }
}
