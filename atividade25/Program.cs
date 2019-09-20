using System;

namespace atividade25
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] produto = new string[6];

            int contador=0;

             while(contador<6){
                System.Console.WriteLine("digite o nome do produto");
                produto[contador] = Console.ReadLine();
                contador++;

             }

            int contador2=0;
             while(contador2<6){
                 System.Console.WriteLine($"Produto:{produto[contador2]}   ");
                 contador2++;
             }
        }
    }
}
