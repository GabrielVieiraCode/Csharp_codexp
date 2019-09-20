using System;

namespace atividade_24
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("digite o numero para saber a tabuada");
           int num =  int.Parse(Console.ReadLine());
           int contador = 0;
           if(num<=0){
               System.Console.WriteLine("digite um nuemro maior 0");
           }
           else{ 
           while(contador<=10){
               System.Console.WriteLine(num+"X"+contador+"="+num*contador);
               contador++;
           }
           }
           

            

        }
    }
}
