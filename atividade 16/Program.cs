using System;

namespace atividade_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ultimo numero de uma placa");
            // int placa = int.Parse(Console.ReadLine());
            string placa =(Console.ReadLine());
            int caracteres = placa.Length;
            int final = int.Parse(placa.Substring(caracteres-1));

            if (final==0||final==1){
                System.Console.WriteLine("Voce pode circular segunda-feira");
            }

            else if(final==2|final==3){
                System.Console.WriteLine("Voce pode circular terça-feira");
            }
            else if(final==4||final==5){
                System.Console.WriteLine("voce pode circulaar na quarta");
            }
            else if(final==6||final==7){
                System.Console.WriteLine("voce pode circular na quinta");
            }
            else if(final>=10){
                System.Console.WriteLine("digite apenas o numero final da placa");
            }
            else{
                System.Console.WriteLine("voce pode circular na sexta");
            }

            

        }
    }
}
