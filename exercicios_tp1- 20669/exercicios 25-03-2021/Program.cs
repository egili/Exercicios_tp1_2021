using System;

namespace exercicios_25_03_2021
{
    class Program
    {
        static void Main(string[] args) { 
            //Primeira Lista de Exercícios TP1- 2021
            //Eliseu Gili - 20669

            /*1) Escreva um algoritmo que solicite ao usuário um número inteiro e escreva em tela o
              valor desse número acrescido do valor 1 */

            int num = 0;

            Console.WriteLine("ex1) escreva um numero:");
            num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(num + 1);

            /*2) Escreva um algoritmo que solicite ao usuário um número inteiro e escreva os próximos
               dois números depois dele */

            Console.WriteLine("ex2) escreva um numero:");
            num = Convert.ToInt16(Console.ReadLine());
            Console.Write(num + 1 + ",");
            Console.WriteLine(num + 2);

            /*3) Escreva um algoritmo que solicite ao usuário um número inteiro e escreva os 3
               números anteriores a ele */

            Console.WriteLine("ex3) escreva um numero:");
            num = Convert.ToInt16(Console.ReadLine());
            num = num - 1;
            Console.Write(num);
            Console.Write(",");
            num = num - 1;
            Console.Write(num);
            Console.Write(",");
            num = num - 1;
            Console.WriteLine(num);

            /*4) Escreva um algoritmo que solicite ao usuário dois números inteiros A e N. Na
               sequência, escreva em tela o valor de A e os N valores numéricos após o A. */

            int a, n;
            do
            {
                Console.WriteLine("ex4) digite um número:");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("digite outro número:");
                n = Convert.ToInt16(Console.ReadLine());

                if (a > n )
                {
                    Console.WriteLine("A não pode ser maior que N");
                }
            } while (!(a < n));

            for (int numY = a; numY <= n; numY++)
                Console.WriteLine(numY);
            // exibe os valores entre A e N

            /*5) Escreva um algoritmo que solicite ao usuário um número inteiro e escreva a sequência
               de valores entre 1 e o número digitado, caso ele seja positivo. Caso ele seja negativo,
               informe ao usuário que o programa só trabalha com valores positivos */
           do
            {
                Console.WriteLine("ex5)digite um número:");
                num = Convert.ToInt16(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("apenas valores positivos");
                }
            } while (!(num > 0));

            for (int numX = 1; numX <= num; numX++) 
                Console.WriteLine(numX);

        }
    }
}
