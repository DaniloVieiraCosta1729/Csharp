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

        // Listas

        public static void ListaDePaises()
        {
            List<string> listaDePaises = new List<string>();
            listaDePaises.Add("Brasil");
            listaDePaises.Add("Índia");
            listaDePaises.Add("Croácia");
            listaDePaises.Add("Austrália");
            listaDePaises.Add("Macedônia do Norte");

            foreach (string pais in listaDePaises)
            {
                Console.WriteLine(pais);
            }
        }

        public static void mediaLista()
        {
            List<int> numeros = new List<int>();
            for (int i = 0; i < 9;i++)
            {
                numeros.Add((int)(Math.PI*Math.Pow(10,i)%10));
            }

            int tamanho = numeros.Count();
            foreach (int numero in numeros)
            {
                System.Console.Write(numero + (tamanho > 1 ? ", " : " "));
                tamanho --;
            }
            double media = numeros.Average();
            Console.WriteLine($"A média dos valores da lista é {media}");
        }

        public static void ListagemPrimosAteN(int n)
        {
            List<int> primos = new List<int>();

            // Teste de primalidade
            for (int i = 2; i <= n; i++)
            {
                int raizDeI = (int)Math.Pow(i, 0.5);
                int divisorDeI = -1;
                bool primo = true;

                if ((i == 2) || (i == 3))
                {
                    continue;
                } else {
                    for (int k = 2; k <= raizDeI; k++)
                    {
                        bool divisor = (i % k == 0) ? true : false;
                        if (divisor)
                        {
                            primo = false;
                            break;
                        }
                    }
                }
                if (primo)
                {
                    primos.Add(i);
                }

            }

            int tamanho = primos.Count;

            foreach (int i in primos)
            {
                string virgula = ((tamanho - 1) > 0) ? ", " : " ";
                System.Console.Write($"{i}{virgula}");
                tamanho --;
            }

        }

        public static void InversorDeArray(params int[] vetor)
        {
            int indice = vetor.Length - 1;
            int i = 0;
            int[] osrevni = new int[indice + 1];

            while (indice >= 0)
            {
                osrevni[i] = vetor[indice];
                indice --;
                i ++;
            }

            System.Console.WriteLine(string.Join(",", osrevni));
        }

        // Para o próximo exercício, vamos criar um delegate 100% desnecessário, mas vamos fazê-lo para já irmos se acostumando com o uso dessa ferramenta.
        delegate bool repetido(int x, int y);

        static bool verificaRepeticao(int x, int y)
        {
            return x == y;
        }

        public static void RemoveDuplicatas(params int[] vetor)
        {
            repetido verifica = verificaRepeticao;

            List<int> listaSemDuplicatas = new List<int>();
            listaSemDuplicatas.Add(vetor[0]);

            for (int x = 1; x < vetor.Length; x++)
            {
                for (int y = 0; y < listaSemDuplicatas.Count; y++)
                {
                    if (verifica(vetor[x], listaSemDuplicatas[y]))
                    {
                        break;
                    } else if (y == listaSemDuplicatas.Count - 1){
                        listaSemDuplicatas.Add(vetor[x]);
                    }
                    
                }
            }

            int[] arraySemDuplicatas = new int[listaSemDuplicatas.Count];

            foreach (int x in listaSemDuplicatas)
            {
                arraySemDuplicatas[listaSemDuplicatas.IndexOf(x)] = x;
            }

            System.Console.WriteLine(string.Join(",", arraySemDuplicatas));
        }
    }
}
