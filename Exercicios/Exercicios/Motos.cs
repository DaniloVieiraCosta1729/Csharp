using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Motos : IVeiculo
    {
        public void Desligar()
        {
            Console.WriteLine("A moto desligou."); ;
        }

        public void Ligar()
        {
            Console.WriteLine("A moto ligou."); ;
        }
    }
}
