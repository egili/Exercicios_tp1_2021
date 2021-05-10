using System;

namespace jogoAdvinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_usuario;
            int erro = 0;
             
                Console.WriteLine("Jogo de Advinhação de Números");

                {
                    Console.WriteLine("Escolha um número <positivo> entre 0 e 50");
                    num_usuario = Convert.ToInt32(Console.ReadLine());

                    if (num_usuario < 0)
                    {
                        Console.WriteLine("insira apenas valores maiores que 0");
                    }
                    else if (num_usuario > 50)
                    {
                        Console.WriteLine("insira apenas valores inferiores a 50");
                    }

                } while ((!(num_usuario > 0)) || (!(num_usuario < 50))) ;

            if(erro >= 0)
            {
                {
                    Random num = new Random();
                    int num_gerado = num.Next(0, 51);

                    if (num_usuario == num_gerado)
                    {
                        Console.WriteLine("voce acertou o numero !!!");
                    }
                    else
                    {
                        Console.WriteLine("nao foi dessa vez, tente de novo");
                        num_usuario = Convert.ToInt32(Console.ReadLine());
                        erro = erro + 1;
                    }
                }
            
            // Console.WriteLine("o numero gerado aleatoriamente foi " + num_gerado);

           } while (erro < 1); // mantive o "erro < 1", pois com "erro < 2" não conseguia digitar novamente depois de errar uma vez

            Console.WriteLine("excedido o limite de tentativas, tente novamente mais tarde");
                //Console.ReadKey();
        }
    }
}
