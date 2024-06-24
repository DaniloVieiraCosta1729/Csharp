using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ReforcandoConceitos
{
    public class Delegates
    {
        public int Maior(int a, int b)
        {
            int resultado = (a > b) ? a : b;

            return resultado;
        }

        public float Maior(float a, float b)
        {
            float resultado = (a > b) ? a : b;

            return resultado;
        }

        // soma dois números
        public delegate int SomaParDeNumeros(int a, int b);

        public static SomaParDeNumeros mais = new SomaParDeNumeros(Soma);

        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static int Subtrai(int a, int b)
        {
            return a - b;
        }

        // delegate anonimo
        public delegate string UniaoTexto(string a, string b);

        // delegate genérico + anônimo
        public delegate Tresultado JuntaTipos<T1, T2, Tresultado>(T1 a, T2 b);

        // Func e Action
        public delegate T3 Func<T1, T2, T3>(T1 a, T2 b);


    }
}
