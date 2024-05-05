using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace Enumeration
{
    // You define enumerations directly in the namespace.
    enum DiasDaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };
    public class Program
    {
        static void Main(string[] args)
        {
            DiasDaSemana hoje;
            hoje = DiasDaSemana.Sabado;
            Console.WriteLine(hoje);

            Console.WriteLine((int)hoje);

            var instanciaDaClasse = new Program();
            int x = instanciaDaClasse.Soma(1,2);
            int y = instanciaDaClasse.Soma(1,3);

            Console.WriteLine($"\n\n{x} + {y} = {x+y}\n\n");
            Console.WriteLine($"5! = {instanciaDaClasse.Fatorial(5)}");

            Console.WriteLine($"O fatorial, usando recursões, de 5 é {instanciaDaClasse.FatorialComRecursao(5)}");

            Console.WriteLine($"\n\nO oitavo termo da sequência de Fibonacci é {instanciaDaClasse.Fibonacci(4)}.;");

            Console.Write("Quantos dados você gostaria de lançar? \nQuantidade: ");
            int qtdDeDados = int.Parse(Console.ReadLine()!);
            instanciaDaClasse.SomaDosDados(qtdDeDados);
        }

        /// <summary>
        /// Função Adição: esse método retorna a soma de dois números.
        /// </summary>
        /// <param name="a">primeiro número</param>
        /// <param name="b">segundo número</param>
        /// <returns>valor da soma</returns>
        public int Soma(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Esse método usa um processo recursivo para calcular os termos da sequencia de fibonacci.
        /// </summary>
        /// <param name="n">Inteiro que representa a posição do termo que você deseja saber o valor.</param>
        /// <returns>n-ésimo termo da sequência.</returns>
        public int Fatorial(int n)
        {
            int i = 1;
            while (n > 0)
            {
                i *= n;
                n--;
            }
            return i;
        }

        /// <summary>
        /// Função Fatorial usando um método recursivo. Fatorial de 1 é 1 e fatorial de n, tal que n é um inteiro maior que 1, é n*fatorial de (n-1).
        /// </summary>
        /// <param name="n">Inteiro n o qual queremos calcular o fatorial.</param>
        /// <returns>Retorna o fatorial de n.</returns>
        public int FatorialComRecursao(int n)
        {
            if (n == 1) 
            {
                return 1;
            }
            return n * FatorialComRecursao(n-1);
        }

        public int Fibonacci(int n)
        {
            int f1 = 1;
            int f2 = 1;

            if ((n == 1) || (n == 2))
            {
                return 1;
            }

            return Fibonacci(n-1) + Fibonacci(n-2);
        }

        public void SomaDosDados(int n)
        {
            Random r = new Random();
            int resultado = 0;
            int dado;
            int contador = 1;

            while (n > 0)
            {
                dado = r.Next(1,7);
                resultado += dado;
                Console.WriteLine($"Dado {contador}: {dado}");
                n--;
                contador++;
            }

            Console.WriteLine($"\nA soma dos {contador - 1} dados é {resultado}.");

            // Page 117;
        }
    }
}
