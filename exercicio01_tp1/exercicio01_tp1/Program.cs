using System;

namespace exercicios_tp1_15_03_21
{
    class Program
    {


        static void Main(string[] args)
        {
            /* 1) Desenvolver um algoritmo que solicite ao usuario uma idade.
              Com base nessa idade você vai dizer pro usuário se ele pode ou 
              não ter habilitação.*/

            Console.WriteLine("Digite a idade:");
            int idade = Convert.ToInt16(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Sua idade é " + idade + ", portanto você não pode dirigir");
            }
            else
            {
                Console.WriteLine("Sua idade é " + idade + ", portanto você pode dirigir");
            }



        }
    }
}
