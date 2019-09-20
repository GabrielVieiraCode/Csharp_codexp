using System;

namespace calculo_do_triplo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um numero para ser triplicado");
            int n=int.Parse(Console.ReadLine());
            int triplo= n*3;
            System.Console.WriteLine("o triplo de "+n+" é "+triplo);
        }
    }
}
