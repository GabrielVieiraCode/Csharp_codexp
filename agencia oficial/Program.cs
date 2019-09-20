using System;

namespace agencia_oficial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("agecnia official");

            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime [] data  = new DateTime[5];

            int opcao=0;
            
            string resposta;

            do
            {
               

                System.Console.WriteLine("Selecione uma opçao");
                
                
                System.Console.WriteLine("1-cadastrar passagens");
                System.Console.WriteLine("2 - lsitar passagens");
                System.Console.WriteLine("0- Sair");

                 opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                    System.Console.WriteLine("Vamos cadastrar agora");
                do{
                    int contador =0;

                    if(contador<=2){


                 System.Console.WriteLine("digite o nome do passageniro");
                nome[contador] = Console.ReadLine();

                System.Console.WriteLine("digite a origem");
                origem[contador] = Console.ReadLine();

                System.Console.WriteLine("Digite o destino");
                destino[contador] = Console.ReadLine();

                System.Console.WriteLine("digite a data");
                data[contador] = DateTime.Parse(Console.ReadLine());

                System.Console.WriteLine("Voce deseja cadastrar mais um? Sim ou Nao");
             
                contador++;
                    }
                else{
                    System.Console.WriteLine("Numeor ");
                    break;
                }
                resposta = Console.ReadLine();
                while(resposta=="Sim");
                break;
                
                   

                }while(contador<6);
                   
                    case 2:
                    int contadorb=0;
                    System.Console.WriteLine("Listando as passagens");
                    System.Console.WriteLine($"passageiros nome:{nome[contadorb]}, origem{origem[contadorb]}");
                    contadorb++;
                    break;
                    case 0:
                     System.Console.WriteLine("Obrigado por usar nosso sistema");
                    break;
                    default:
                    System.Console.WriteLine("opçao invalida");
                    break;

                }
                   
                

            }while(opcao!=0);

           
           

        }
    }
}
