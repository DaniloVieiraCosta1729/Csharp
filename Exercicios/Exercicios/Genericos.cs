using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Genericos
    {
        public static void TrocarValores<T>(ref T x, ref T y)
        {
            T temporario = x;

            x = y;

            y = temporario;
        }
    }

    // exercício 1
    public class Par<T1, T2>
    {
        public T1 Primeiro { get; set; }
        public T2 Segundo { get; set; }

        public Par(T1 primeiro, T2 segundo)
        {
            Primeiro = primeiro;
            Segundo = segundo;
        }

        public void Define(T1 primeiro, T2 segundo)
        {
            Primeiro = primeiro;
            Segundo = segundo;
        }

        public void Mostra()
        {
            Console.WriteLine($"{Primeiro}  {Segundo}");
        }
    }

    // exercicio 2
    public class UltimoElemento
    {
        public static T ObterUltimoElemento<T>(List<T> lista)
        {
            if (lista.Count == 0 || lista == null)
            {
                throw new ArgumentException("A lista não pode ser vazia nem nula.");
            }
            return lista[lista.Count - 1];
        }
    }

    // Implementando uma stack
    public class Pilha<T>
    {
        int indice; // Por padrão, o C# atribui 0 para o tipo int quando não atribuímos nenhum valor.
        T[] dados = new T[50];

        // Métodos
        public void Push(T dado)
        {
            dados[indice++] = dado; // o operador de pós-incremento (variável++): utiliza a variável e, depois de usá-la, adiciona 1 ao seu valor.
        }
        public T Pop()
        {
            return dados[--indice]; // o operador de pré-decremento (--variável): subtrai 1 da variável e então a utiliza.
        }

    }

    // Vamos criar uma classe e um método que utilize múltiplos tipos de argumentos
    public class CriaArrays<T1,T2,T3>
    {
        private T1[] _array1 = new T1[3];
        private T2[] _array2 = new T2[3];
        private T3[] _array3 = new T3[3];

        int indice;

        public void Push(T1 x, T2 y, T3 z)
        {
            _array1[indice] = x;
            _array2[indice] = y;
            _array3[indice++] = z;
        }

        public void showww()
        {
            Console.WriteLine("Primeiro tipo:");
            Console.WriteLine(string.Join(", ", _array1));

            Console.WriteLine("Segundo tipo:");
            Console.WriteLine(string.Join(", ", _array2));

            Console.WriteLine("Terceiro tipo:");
            Console.WriteLine(string.Join(", ", _array3));
        }
    }
     
    public class TurmaX<T1,T2>
    {
        private T1 _nome;
        private T2[] _notas = new T2[3];

        int index = 0;

        public TurmaX(T1 nome)
        {
            _nome = nome;
        }

        public void AdicionarNota(T2 nota)
        {
            if (index < 3)
            {
                _notas[index++] = nota;
            } else
            {
                Console.WriteLine($"Todas três notas de {_nome} já foram atribuídas.");
            }
        }

        public void MostrarNotas()
        {
            Console.WriteLine($"As notas de {_nome} foram: {string.Join(", ", _notas)}");
        }
    }

}
