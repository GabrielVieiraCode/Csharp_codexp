using System;

namespace arrays_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("arrays");
            string[] nome = new string[5];
            string[] telefones = new string[5];
            string[] email = new string[5];
            
            int contador=0;
            

            while(contador<5){
                System.Console.WriteLine("digite seu nome");
                nome[contador] = Console.ReadLine();
                

                 System.Console.WriteLine("digite seu telefone");
                telefones [contador] =Console.ReadLine();
                
                
                System.Console.WriteLine("digite seu email");
                
                email[contador] = Console.ReadLine();

                contador++;
            }

            int contadorB = 0;

            while(contadorB<=4){
                System.Console.WriteLine($"O cliente número {contadorB+1}° -Nome: {nome[contadorB ]} telefone: {telefones[contadorB]} email: {email[contadorB]} ");
                contadorB++;
            }

          
            

        }
    }
}
