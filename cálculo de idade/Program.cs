using System;

namespace cálculo_de_idade
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("digite sua idade");
           int idade = int.Parse(Console.ReadLine());
                                  
           int meses = idade*12;
           Console.WriteLine("meses de vida "+meses);

           int dias = idade*365;
           Console.WriteLine("seus dias de vida sao "+dias);

           int hora= dias*24;
           Console.WriteLine("suas horas de vida sao: "+hora);

           int minuto = hora*60;
           Console.WriteLine("seus minutos de vida sao: "+minuto);
           if(idade >30){
               Console.WriteLine("voce esta velho");
           }
           else{
               Console.WriteLine("ta novo");
           }
           

        }
    }
}
