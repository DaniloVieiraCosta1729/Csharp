using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Produto
    {
        // Campos
        private string _nome;
        private double _preco;
        private int _quantidade;

        // Propriedades
        public string Nome { get { return _nome; } set { _nome = value; } }
        public double Preco { get { return _preco; } set { _preco = value; } }
        public int Quantidade { get { return _quantidade; } set { _quantidade = value; } }

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        // Método não-estático, i.e., um método dos objetos de Produto.
        public void EstoqueProduto()
        {
            Console.WriteLine($"Há {_quantidade} unidades de {_nome}.");
        }

        public void ValorEstoque()
        {
            Console.WriteLine($"O valor total do estoque de {_nome} é R$ {_quantidade*_preco}");
        }
    }
}
