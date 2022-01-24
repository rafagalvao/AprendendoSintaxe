using System;

namespace AprendendoSintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retorna na tela as informações escritas e pula uma linha
            Console.WriteLine("Bem vindos ao Curso de Sintaxe!");

            //Retorna na tela as informaçções escritas e não pula uma linha
            Console.Write("meu nome é Rafael ");
            Console.Write("e eu tenho 25 anos. ");

            Console.WriteLine();
            Console.WriteLine("---------------------");


            //Como declarar uma variável e tipos de valor

            //Números Inteiros
            sbyte n1 = 127;
            short n2 = 2000;
            int n3 = 5490;
            long n4 = 200000000000;

            //Pontos flutuantes
            double n5 = 99.90;
            float n6 = 99.90f;

            //Verdadeiro ou falso
            bool resposta = true;

            //Apenas um caractere
            char identidade = 'F';

            //Como escrever um texto
            string nome = "Rafael";

            //Realizando operações
            int numero = 99*9;
            double numero2 = 2.99 * 4.18;

            Console.WriteLine("Números Inteiros:");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("Números com Pontos Flutuantes:");
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            Console.WriteLine("Verdadeiro ou Falso:");
            Console.WriteLine(resposta);

            Console.WriteLine("Apenas um caractere:");
            Console.WriteLine(identidade);

            Console.WriteLine("Escrever um texto:");
            Console.WriteLine(nome);

            Console.WriteLine("Realizando Operações:");
            Console.WriteLine(numero);
            Console.WriteLine(numero2);
            Console.WriteLine("Obrigado por assistir esse curso!");
        }
    }
}


