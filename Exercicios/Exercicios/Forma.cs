using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Forma
    {
        public virtual void CalculaArea()
        {
            Console.WriteLine("A área dessa forma é X");
        }
    }

    public class Retangulo : Forma
    {
        public override void CalculaArea()
        {
            Console.WriteLine("A área do retangulo é base x altura.");
        }
    }

    public class Circulo : Forma
    {
        public override void CalculaArea()
        {
            Console.WriteLine("A área do circulo é pi x r².");
        }
    }
}
