using System;

namespace atividade_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade de 10 pessoas");

             int[] idade  = new int [10];
             int contador = 0;
             int maior=0;
             int menor=0;


             do{
                 idade[contador] =int.Parse(Console.ReadLine());
                 contador++;
                 
                   if(idade[contador]<=18){
                       maior++;

                 
             }
             else{
                 menor++;
                
             }

             }while(contador<=10);

             System.Console.WriteLine($"maiores de idade{maior}");
             System.Console.WriteLine($"menores {menor}");

             


            

           


              




        }
    }
}
