using System;

namespace exercicio2_tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2) Desenvolver um algoritmo qu solicite o nome de um usuário e a sua idade. 
              Com base na idade você vai classificar ele em 1 de 3 categorias de acordo com a tabela abaixo

               0 .. 10 anos de idade --> Infantil
              11 .. 17 anos de idade --> Juvenil
              18 .. XX anos de idade --> Adulto */

            int idade;

            Console.WriteLine("Sua idade:");
            idade = Convert.ToInt16(Console.ReadLine());

            string condicao;

            if (idade < 11)
            {
                condicao = "infantil";
                Console.WriteLine(condicao);
            }
            else if (idade < 18)
            {
                condicao = "juvenil";
                Console.WriteLine(condicao);
            }
            else
            {
                condicao = "adulto";
                Console.WriteLine(condicao);
            }
        }
    }
}
