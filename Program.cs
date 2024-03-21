//@niallivmi
using System;

namespace Pgc1Aula03Ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Variável booleana para laço de refazer o cálculo
            bool verifica;

            //laço
            do {
                string verificador; //Variável para verificar S/N do usuário
                float salario, desconto; //Variáveis para cálculo de desconto

                Console.WriteLine("     Cálculo de desconto INSS");
                Console.WriteLine("-------------------------------------");

                Console.Write("Digite seu salário (0000,00):");
                salario = float.Parse(Console.ReadLine());

                //Verificação do valor do salário
                if (salario <= 1045)
                {
                    //Cálculo com desconto de 7,5%
                    desconto = salario * 7.5f / 100;
                    Console.WriteLine("Seu salário é: R$" + salario + ",00");
                    Console.WriteLine("O valor do desconto é de: R$" + desconto);
                } else if (salario <= 2089.60)
                {
                    //Cálculo com desconto de 9%
                    desconto = salario * 9f / 100;
                    Console.WriteLine("Seu salário é: R$" + salario + ",00");
                    Console.WriteLine("O valor do desconto é de: R$" + desconto);
                } else if (salario <= 3134.40)
                {
                    //Cálculo com desconto de 12%
                    desconto = salario * 12f / 100;
                    Console.WriteLine("Seu salário é: R$" + salario + ",00");
                    Console.WriteLine("O valor do desconto é de: R$" + desconto);
                } else if (salario <= 6101.06)
                {
                    //Cálculo com desconto de 14%
                    desconto = salario * 14f / 100;
                    Console.WriteLine("Seu salário é: R$" + salario + ",00");
                    Console.WriteLine("O valor do desconto é de: R$" + desconto);
                }

                Console.WriteLine("Deseja refazer o cálculo? (S/N)");
                Console.Write(">> ");
                verificador = Console.ReadLine();

                //Verifica se a resposta foi S para refazer o cálculo
                verifica = (verificador.ToUpper() == "S");
                Console.Clear();
            } while (verifica);
            {
                Console.WriteLine("O programa será fechado!");
                Environment.Exit(0);
            }

            Console.ReadKey();
        }
    }
}
