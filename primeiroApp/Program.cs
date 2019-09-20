using System;

namespace primeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine( "Digite um numero");
            int n1=int.Parse(Console.ReadLine());
             System.Console.WriteLine("digite o segundo numero");
            int n2=int.Parse(Console.ReadLine());
            
            
            if(n1<0||n2<0){
                System.Console.WriteLine("Digite um numero maior que zero");
            }
            else{
              int cal= n1+n2;
              System.Console.WriteLine( "resultado"+ cal);
            }
    }
            }
            
            }

