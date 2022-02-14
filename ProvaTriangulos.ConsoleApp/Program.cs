using System;

namespace ProvaTriangulos.ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)

     
        {

            string opcao;
            do
            {

                Console.WriteLine("Introduza x: ");
                string strX = Console.ReadLine(); 

                Console.WriteLine("Introduza y: ");
                string strY = Console.ReadLine();

                Console.WriteLine("Introduza z: ");
                string strZ = Console.ReadLine();


                //variaveis
                double X = Convert.ToDouble(strX);
                double Y = Convert.ToDouble(strY);
                double Z = Convert.ToDouble(strZ);

                if (X == Y && X == Z)
                {
                    Console.WriteLine("Triangulo Equilátero!");
                    Console.ReadLine();
                }
                else if (X == Z && X != Y || X == Y && X != Z || Z == Y && Z != X || Z == X && Z != Y)
                {
                    Console.WriteLine("Triangulo Isóceles!");
                    Console.ReadLine();
                }

                else if (X + Y < Z || X + Z < Y || Y + Z < X || X <= 0 || Y <= 0 || Z <= 0)
                {
                    Console.WriteLine("Triangulo Invalido!");
                    Console.ReadLine();
                }

                else
                    Console.WriteLine("Triangulo Escaleno! ");
                Console.ReadLine();



                Console.WriteLine("Deseja Continuar ? \nDigite 1 Para continuar \nDigite 2 Para sair");
                opcao = Console.ReadLine();

                 if (opcao == "2")
                {
                    Console.WriteLine("Muito Obrigado Volte Sempre!");
                    Console.ReadLine();
                    break;
                }


                else if (opcao == "1")
                {
                    Console.Clear();
                    continue;

                }
                else if (opcao != "1" || opcao != "2" )
                {
                    Console.WriteLine("Opçao invalida, tente novamente !");
                    Console.ReadLine();
                    
                   
                }


            } while (opcao == "1" || opcao != "2");
          
            

        }
    }
}
