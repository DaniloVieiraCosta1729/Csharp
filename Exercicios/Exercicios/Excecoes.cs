using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Excecoes
    {
        public static void ForaDoArray()
        {
            try
            {
                int[] vetor = { 1, 2, 3, 4, 5};

                int decimo = vetor[10];

                Console.WriteLine(decimo);
            } catch (IndexOutOfRangeException excecao)
            {
                Console.WriteLine($"O índice escolhido está fora do range do array.");

                Console.WriteLine(excecao.Message);

            } finally
            {
                Console.WriteLine("Esse é o código no bloco finally.\nIsso sempre é executado inpendentemente de haver ou não uma excecao.");
            }
        }

        // Exercício 1
        public static void ArrayEIndice(int[] vetor, int indice)
        {
            if (indice > vetor.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            Console.WriteLine(vetor[indice]);
        }

        // Exercício 2
        public static void divisao(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            Console.WriteLine(a/b);
        }
    }

    public class EstoqueInsuficienteException : Exception
    {
        // Vamos iniciarlizar o construtor com uma chamada do construtor da classe base e passando uma mensagem personalizada como parametro.
        public EstoqueInsuficienteException() : base("Estoque insulficiente.") { }
    }
}
