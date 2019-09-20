using System;

namespace atividade_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salario");
            float sal = float.Parse(Console.ReadLine());
            if(sal< 990){
            double aumento = sal*0.3;
            double saltotal = aumento +sal;
                System.Console.WriteLine($"Parabens voce tera um aumento seu salario atual é: R${sal} e recebera um aumento de  R${aumento}, seu salariro atual será R${saltotal}");
            }
            else{
                System.Console.WriteLine("Voce nao tem direito ao aumento");
            }
        }
    }
}
