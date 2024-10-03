using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Elabore um programa que:
//1) Leia 10 valores inteiros e armazene em um vetor.
//2) Após fazer todas as leituras, separe os valores em 2 vetores
//vetor_par
//vetor_impar
//3) Mostre o conteúdo dos 3 vetores no final
namespace Ex_Vetor_Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tam = 10;
            int[] vetor = new int[tam];
            int[] vetor_impar = new int[tam];//tam é igual para os 2 casos
            int[] vetor_par = new int[tam];  //podem ser todos os valores impares ou pares
            int qtd_par = 0, qtd_impar = 0; //Vou precisar controlar as quantidade de valores separados

            Console.WriteLine($"Informe {vetor.Length} valores :");
            for (int cont = 0; cont < vetor.Length; cont++)
            {
                bool valorcorreto; //Controle para saber se foi digitado um valor correto
                do
                {
                    valorcorreto = true;//True=>Defino que o usuário não vai fazer nada de errado! (Imagina!)
                    Console.Write($"Vetor[{cont}]= ");
                    if (int.TryParse(Console.ReadLine(), out int resposta)==true)
                        vetor[cont] = resposta;
                    else
                    {
                        Console.WriteLine("Informe um valor correto!");
                        valorcorreto = false;//False=> Se der algo errado.Então precisa voltar e digitar de novo
                    }
                } while (!valorcorreto);
            }

            //Iniciando a separação dos valores em par e impar
            for (int cont = 0; cont < vetor.Length; cont++)
            {
                if (vetor[cont] % 2 == 0) //Se for par
                {
                    vetor_par[qtd_par++] = vetor[cont];
                    //copio o valor par na posição vazia em vetor_par
                    //depois de copiar, vou para a próxima posição
                    //Lembrete: qtd_par define a quantida de pares
                }
                else //Se for impar
                {
                    vetor_impar[qtd_impar++] = vetor[cont];
                }
            }

            //Imprimindo os valores
            // Troca as cores - Perfumaria
            //Console.ForegroundColor = ConsoleColor.Black; // Cor do texto
            //Console.BackgroundColor = ConsoleColor.White; // Cor de fundo

            Console.WriteLine("\n\nOs valores contidos no vetor principal são:");
            for (int i = 0; i < vetor.Length; i++)
                Console.WriteLine($"vetor[{i}] = {vetor[i]}");
            //Vetor Par
            if (qtd_par > 0)
            {
                Console.WriteLine("\nOs valores pares são:");
                for (int i = 0; i < qtd_par; i++) //qtd_par é o limite de impressão
                    Console.WriteLine($"vetor_par[{i}] = {vetor_par[i]}");
            }
            else
                Console.WriteLine("\n\nNão foram informados valores pares");
            //Vetor Impar
            if (qtd_impar > 0)
            {
                Console.WriteLine("\nOs valores ímpares são:");
                for (int i = 0; i < qtd_impar; i++)//qtd_impar é o limite de impressão
                    Console.WriteLine($"vetor_impar[{i}] = {vetor_impar[i]}");
            }
            else
                Console.WriteLine("\n\nNão foram informados valores ímpares");

            //Ordenando o vetor principal
            Array.Sort(vetor);
            //Imprimindo o vetor ordenado
            Console.WriteLine("\n\nBÔNUS:\nOs valores ORDENADOS do vetor principal são:");
            foreach(int valor in vetor) //"Para cada" valor (do tipo inteiro, que é o tipo do vetor) que está dentro de vetor
                Console.WriteLine($"{valor}");
            Console.ReadKey();
        }
    }
}
