using System;

namespace atividade_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota de 10 alunos");
            double[] nota = new double [10];
            double[] nota2 = new double [10];
            double[] media = new double[10];
             int aprovado=0;
             int reprovado=0;
            
           int contador = 0;
            do{

                System.Console.WriteLine($"Digite a 1° nota");

                nota[contador]= double.Parse(Console.ReadLine());

                System.Console.WriteLine($"Digite a 2° nota");

                nota2[contador] = double.Parse(Console.ReadLine());

                media [contador]= (nota[contador]+nota2[contador])/2;
                
                              
                 if(media[contador]>=7){

                 aprovado++;
                }
                else{
                   reprovado++;
                }
                contador++;


            }while(contador<10);

             int contadorB = 0;
            double somaMedia = 0;
            while(contadorB<10){
                somaMedia = somaMedia + media[contadorB];
                contadorB++;

            }
             System.Console.WriteLine($"A media da sala é:{somaMedia/2} temos {aprovado}aprovados e {reprovado} reporvados");
             

        }
    }
}
