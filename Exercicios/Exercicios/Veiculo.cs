using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public int Ano { get; set;}

        public virtual void Info()
        {
            Console.WriteLine($"Marca: {Marca};\nAno: {Ano}.");
        }
    }

    public class Carros : Veiculo
    {
        private string _modelo;

        public string Modelo { get => _modelo; set => _modelo = value; }

        public override void Info()
        {
            Console.WriteLine($"Marca: {Marca};\nModelo: {Modelo};\nAno: {Ano}.");
        }
    }

    public class Moto : Veiculo
    {
        private int _cilindradas;
        private string _modelo;

        public int Cilindradas { get => _cilindradas; set => _cilindradas = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }

        public override void Info()
        {
            Console.WriteLine($"Marca: {Marca};\nModelo: {Modelo};\nCilindradas: {Cilindradas};\nAno: {Ano}.");
        }
    }
}
