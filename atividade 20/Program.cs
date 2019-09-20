using System;

namespace atividade_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros");
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if(num%2 == 0){
                System.Console.WriteLine("numero par");

            }
            else{
                System.Console.WriteLine("numero impar");
            }

             if(num>num2){
                System.Console.WriteLine($"maior numero é {num}");
            }
            else{
                System.Console.WriteLine($"maior numero é: {num2}");
            }
            if(num2%2 == 0){
                System.Console.WriteLine("numero par");

            }
            else{
                System.Console.WriteLine("numero impar");
            }
            
        }
    }
}
