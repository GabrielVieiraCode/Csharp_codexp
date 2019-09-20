using System;

namespace arrey
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] nomes = new string[3];
           int contador = 0;

           while(contador<3){
               System.Console.WriteLine($"Digite o {contador+1}°nome");
               nomes[contador]=Console.ReadLine();
               contador++;
           }

           contador=0;
           while(contador<3){
               System.Console.WriteLine($"O nome na posiçao {contador} é {nomes[contador]}");
               contador++;
           }

        }
    }
}
