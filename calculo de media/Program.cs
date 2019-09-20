using System;

namespace calculo_de_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de media");
            System.Console.WriteLine("Digite a priemira nota");

            float n1=float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");

            float n2=float.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a terceira nota");

            float n3=float.Parse(Console.ReadLine());

            float media = (n1+n2+n3)/3;
            
            System.Console.WriteLine("sua media é:"+media);
             if(media>7){
                Console.WriteLine( "aluno aprovado");
            }
            else{
                Console.WriteLine("aluno reprovado");
            }
             

        }
    }
}
