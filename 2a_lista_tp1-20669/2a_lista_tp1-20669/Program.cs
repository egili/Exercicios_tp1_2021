using System;

namespace _2a_lista_tp1_20669
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2a Lista de exercícios de tp1 
            //Eliseu Gili - 20669

            //ex1
            int num, res, i;
            i = 1;

            Console.WriteLine("ex1) digite um número e veja sua tabuada:");
            num = Convert.ToInt16(Console.ReadLine());
            
            while (i <= 10)
            {
                res = i * num;
                Console.WriteLine(String.Concat(num, " X ", i, " = ", res));
                i += 1;
            }

            //ex2
            Console.WriteLine("ex2) digite um número:");
            num = Convert.ToInt16(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

            //ex3 - deixei esse comentado pois,
            //por falta de conhecimento na sintaxe do C#,
            //não consegui fazer rodar

          /*int resto;
            Console.WriteLine("ex3) digite um número:");
            num = Convert.ToInt16(Console.ReadLine());

            for (int numX = 1; numX <= num; resto = num % numX)
                if ( resto == 0 ){
                    Console.WriteLine("estes são os divisores do seu número: " + numX);

                }*/

        }
    }
}
