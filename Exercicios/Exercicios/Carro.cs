using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Carro : IVeiculo
    {
        public void Desligar()
        {
            Console.WriteLine("O carro desligou."); ;
        }

        public void Ligar()
        {
            Console.WriteLine("O carro ligou.");
        }
    }
}
