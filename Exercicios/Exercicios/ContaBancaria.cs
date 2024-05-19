using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class ContaBancaria
    {
        private string _numeroConta;
        private decimal _saldo;

        public string NumeroConta { get => _numeroConta; set => _numeroConta = value; }
        public decimal Saldo { get => _saldo; set => _saldo = value; }

        public ContaBancaria(string numeroConta, decimal saldo)
        {
            this._saldo = saldo;
            this._numeroConta = numeroConta;
        }

        public void Depositar(decimal deposito)
        {
            Saldo += deposito;
            Console.WriteLine("Deposito bem sucedido.");
        }

        public void Sacar(decimal saque) 
        {
            if (saque > Saldo)
            {
                Console.WriteLine($"Impossível realizar a operação, pois o seu saldo (R$ {Saldo}) é insuficiente.");
            }
            else
            {
                Saldo -= saque;
                Console.WriteLine("Saque efetuado.");
            }
        }

        public void Extrato()
        {
            Console.WriteLine($"Seu saldo é R$ {Saldo}");
        }
    }
}
