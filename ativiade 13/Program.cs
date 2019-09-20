using System;

namespace ativiade_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());
            if(idade<=7){
                System.Console.WriteLine("sua categoria é: infantil A");
                          
                           
        }
        else if(idade<=10){
            System.Console.WriteLine("sua categoria é: infantil B");

        }
        else if (idade<=13){
            System.Console.WriteLine("sua categoria é: juvenil A");
        }
        else if(idade<=17){
            System.Console.WriteLine("sua categoria é : juvenil B");

        }
        else {
            System.Console.WriteLine("sua categoria é: Adulto");
        }
        
    }
}
 }
 

