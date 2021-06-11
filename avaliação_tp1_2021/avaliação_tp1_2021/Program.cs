using System;

namespace avaliação_tp1_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Desenvolva um programa que solicite ao usuário dois valores numérico
               e escreva em tela qual o maior valor digitado.Se os valores digitados
               forem iguais, escreva que eles são iguais portanto não existe um valor maior. */


            Console.WriteLine("Escreva um Numero");
            int numA = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escreva outro Numero");
            int numB = Convert.ToInt16(Console.ReadLine());
            if (numA == numB)
            {
                Console.WriteLine("os dois numeros sao iguais");
            }
            else if (numA > numB)
            {
                Console.WriteLine("o maior valor informado eh: " + numA);
            }
            else
            {
                Console.WriteLine("o maior valor informado eh: " + numB);
            }

            /* Desenvolva um programa que solicite ao usuário um valor numérico 
               e escreva em tela se esse valor é positivo, negativo ou neutro. */

            Console.WriteLine("\n Escreva um Numero");
            int num = Convert.ToInt16(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("o valor informado eh neutro");
            }
            else if (num > 0)
            {
                Console.WriteLine("o valor informado eh positivo");
            }
            else
            {
                Console.WriteLine("o valor informado eh negativo");
            }

            /* Desenvolva um programa que solicite ao usuário qual o seu nome e qual a sua idade. 
               Depois de conseguir os dados, verifique se a idade do usuário é um número par ou 
               um número ímpar. Se for um número par, escreva o nome do usuário seguido da frase
               "Aceito para o exame" e se for um número ímpar, escreva o nome do usuário seguido 
                da frase "Espere a próxima oportunidade" */
            String nome;
            int idade;

            Console.WriteLine("qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("qual sua idade?");
            idade = Convert.ToInt16(Console.ReadLine());

            if (idade % 2 == 0)
            {
                Console.WriteLine(nome + ", voce foi aceito para o exame");
            }
            else
            {
                Console.WriteLine(nome + ", espere a proxima oportunidade");
            }
        }
    }
}
