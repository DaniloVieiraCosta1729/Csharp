using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public abstract class FormaGeometrica
    {
        public abstract double CalculaArea();
        public void MostrarArea()
        {
            Console.WriteLine($"A área da figura é {CalculaArea()}");
        }

    }
}
