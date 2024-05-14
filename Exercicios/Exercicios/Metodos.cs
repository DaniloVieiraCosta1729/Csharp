using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Metodos
    {
        public static void Estatico()
        {
            Console.WriteLine("Esse método é estático, portanto não precisa de uma instancia da classe Metodos para ser chamado.");
        }

        public void Saudacao(string nome)
        {
            Console.WriteLine($"Iae, {nome}!");
        }

        public int Fatorial(int n)
        {
            int fatorial = 1;
            foreach (int i in Enumerable.Range(1,n))
            {
                fatorial *= i;
            }
            return fatorial;
        }

        public double CalcularAreaRetangulo(double b, double h)
        {
            return b * h;
        }
    }
}
