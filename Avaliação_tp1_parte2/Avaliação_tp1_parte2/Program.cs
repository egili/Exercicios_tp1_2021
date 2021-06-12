using System;

namespace Avaliação_tp1_parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa que escreva em tela os valores de 10 a 20, inclusive o 10 e o 20 */
            int a = 10;
            int b = 20;

            while (a <= b)
            {
                Console.WriteLine(a + "");
                a = a + 1;
            }


            /*Desenvolva um programa que solicite ao usuário um valor inteiro e indique em tela se ele é par ou impar.
               Seu programa deve repetir essa solicitação e indicação da resposta quantas vezes o usuário quiser. 
               Indique ao usuário que, caso ele queira sair do programa, basta digitar o valor zero (0)*/

            int num;
            do
            {
                Console.WriteLine("insire um numero:");
                Console.WriteLine("digite 0 caso queira sair do programa");
                num = Convert.ToInt16(Console.ReadLine());

                if (num == 0)
                {

                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("vc inseriu um numero par");
                }
                else
                {
                    Console.WriteLine("vc inseriu um numero impar");
                }

            } while (num != 0);

            /*Desenvolva um programa que atenda os seguintes requisitos:
          1) solicite o nome do usuário;
          2) solicite o valor do salário do usuário;
          3) calcule o desconto sobre o salário do usuário de acordo os valores tabelados:
            a) salário entre 0 e 500,00 = isento,
            b) salário entre 500,01 e 1000,00 = 5%
            c) 1000,01 acima = 10%;
          4) escreva o valor do salário com desconto;
          5) repita as ações acima até que o nome do usuário seja deixado em branco.*/

            String nome, status;
            int salario, desconto;
            //  do
            // {
            Console.WriteLine("qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine(nome + ", informe o seu salário: ");
            salario = Convert.ToInt16(Console.ReadLine());

            if (salario <= 500.00)
            {
                status = "isento de desconto";
                Console.WriteLine(nome + ", seu salario esta " + status);
            }
            else if (salario <= 1000.00)
            {
                desconto = (int)(0.05 * salario);
                salario = salario - desconto;
                status = "desconto de 5%";
                Console.WriteLine(nome + ", seu salario sofre um " + status + " e fica: " + salario);
            }
            else
            {
                desconto = (int)(0.10 * salario);
                salario = salario - desconto;
                status = "desconto de 10%";
                Console.WriteLine(nome + ", seu salario sofre um " + status + " e fica: " + salario);
            }
            // } while (!(nome = " "));

            /*Desenvolva um programa que solicite ao usuário um valor final do tipo inteiro e escreva todos 
              os números entre 1 e o valor indicado pelo usuário. Caso o valor indicado seja 0, não escreva nenhum valor. 
              Caso o valor seja negativo, transforme-o em positivo e escreva a sequência considerando esse valor positivo como valor final.*/

            int numero;

            Console.WriteLine("dgite um numero que lhe mostrarei a sequencia entre  1 e ele: ");
            numero = Convert.ToInt16(Console.ReadLine());

            if (numero < 0) // transforma negativo em positivo
            {
                numero -= (numero * 2);
                Console.WriteLine("o valor digitado esta negativo, portanto o converterei para positivo: " + numero);
            }

            for (int numero2 = 1; numero2 <= numero; numero2++)
                Console.WriteLine(numero2);
    }

    }
}
