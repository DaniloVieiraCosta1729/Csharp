using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Quadrados : FormaGeometrica
    {
        private double _x;
        
        public override double CalculaArea()
        {
            return _x*_x;
        }

        public Quadrados( double x, double y)
        {
            this._x = x;
            Console.WriteLine($"A diagonal é: {diagonal(x)}");
        }

        public delegate double Diagonal(double x);

        Diagonal diagonal = new Diagonal( x => x*Math.Pow(2,0.5));

    }
}
