using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Arrays
    {
        // Declaração de array
        int[] vetor1 = new int[5];

        // Inicialização de array
        int[] vetor2 = {1, 2, 3, 4 };

        // Consulta em um array
        public static void consultaArray()
        {
            int[] phi = { 1, 6, 1, 8, 0, 3, 3, 9, 9 };
            Console.WriteLine(phi[5]);
        }

        // Alterar valor de um elemento
        public static void MudaValor()
        {
            Console.WriteLine("=================== Mudar o Valor ===================");
            int[] phi = { 1, 6, 1, 8, 0, 3, 3, 9, 9 };
            string arrayEmTexto = "";
            int indice;
            int valor;
            int restantes = phi.Length - 1;

            foreach (int i in phi) 
            {
                string virgula = (restantes > 0) ? ", " : "";
                arrayEmTexto += $"{i}{virgula}";

                restantes--;
            }

            Console.WriteLine($"Array = [{arrayEmTexto}]");
            Console.WriteLine("Escolha o indice: ");
            indice = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEscolha o novo valor: ");
            valor = int.Parse(Console.ReadLine());

            phi[indice] = valor;
            restantes = phi.Length - 1;
            arrayEmTexto = "";
            // repetição de código -_-' rs
            foreach (int i in phi)
            {
                string virgula = (restantes > 0) ? ", " : "";
                arrayEmTexto += $"{i}{virgula}";

                restantes--;
            }
            Console.WriteLine($"Array = [{arrayEmTexto}]");
        }

        public static void ArrayDePaises()
        {
            string[] paises = new string[5] { "Brasil", "Moçambique", "Papoa Nova Guiné", "Gloriosa República de Vanuatu", "Corea" };
            foreach (string s in paises)
            {
                Console.WriteLine(s);
            }
        }

        public static void MediaArray()
        {
            int[] listaDeNumeros = new int[5] { 3, 5, 7, 9, 11 };
            // Vamos calcular a média de duas formas.

            // 1°
            double mediaFOREACH = 0;
            foreach (int i in listaDeNumeros)
            {
                mediaFOREACH += i;
            }
            mediaFOREACH /= listaDeNumeros.Length;

            Console.WriteLine($"Através do foreach, a média foi {mediaFOREACH}.");

            // 2°
            double mediaLINQ = listaDeNumeros.Average();
            Console.WriteLine($"Através do LINQ, a média foi {mediaLINQ}.");
        }

        public static void Matriz3x3Aurea()
        {
            int[] matriz3x3 = new int[9] { 1, 6, 1, 8, 0, 3, 3, 9, 9 };
            int k = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"|{matriz3x3[k]}  {matriz3x3[k + 1]}  {matriz3x3[k + 2]}|");
                k += 3;
            }
        }
    }
}
