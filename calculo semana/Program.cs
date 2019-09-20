using System;

namespace calculo_semana
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("digite o ano que voce nasceu");
           int ano =int.Parse(Console.ReadLine());
           int idade= 2019-ano;
           int mes= idade*12;
           int sem= mes*4;
           System.Console.WriteLine("sua idade é "+idade + " suas semanas de vida sao "+sem);
        }
    }
}
