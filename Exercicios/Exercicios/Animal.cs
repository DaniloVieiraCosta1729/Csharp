using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Animal
    {
        private string _nome;

        public string Nome { get => _nome; set => _nome = value; }

        // método virtual para a aplicação do conceito de polimorfismo.
        public virtual void FazerSom()
        {
            Console.WriteLine("O animal faz som.");
        }
    }

    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} está latindo.");
        }
    }

    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} está miando.");
        }
    }
}
