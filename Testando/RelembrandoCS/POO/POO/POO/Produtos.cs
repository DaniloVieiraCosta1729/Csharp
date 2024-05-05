using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Produtos
    {
        private string _nome; // Atributo;

        public string Nome {
            get
            {
                return _nome;
            }
            set 
            { 
                if (value.Length > 1) 
                {
                    _nome = value;
                }
                else
                {
                    throw new ArgumentException("Nome inválido. Um nome deve conter mais de 1 caractere.");
                }
            }
        } // Propriedade;
        public float Preco { get; set; }

        public int Estoque { get; private set; }

        public Produtos(int estoque)
        {
            this.Estoque = estoque;
        }

        /// <summary>
        /// Método construtor sobrecarregado.
        /// </summary>
        /// <param name="nome">Nome do produto</param>
        /// <param name="preco">Preço do produto</param>
        public Produtos(string nome, float preco)
        {
            this._nome = nome;
            this.Preco = preco;
        }

        public int Vender(int qtde)
        {
            if (this.Estoque - qtde >= 0)
            {
                this.Estoque -= qtde;
            }
            return this.Estoque;
        }

        public int Comprar(int qtde)
        {
            this.Estoque += qtde;
            return this.Estoque;
        }

        public string DetalhesDoProduto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nProduto: {this.Nome}\n");
            sb.Append($"Preço: R$ {this.Preco}\n");
            sb.Append($"Estoque: {this.Estoque}");

            return sb.ToString();

        }
    }
}
