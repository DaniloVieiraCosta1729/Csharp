using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class DelegatesAndEvents
    {
        public delegate int Operacao(int a, int b);

        private Operacao soma;
        private Operacao multiplicacao;
        private Operacao divisao;
        private Operacao subtracao;

        public DelegatesAndEvents()
        {
            soma = (x, y) => x + y;
            multiplicacao = (x, y) => x * y;
            divisao = (x, y) => { if (y == 0) { Console.WriteLine("A divisao por 0 não está definida"); return -1; }; return x / y; };
            subtracao = (x, y) => x - y;
        }

        public void mostraResultado()
        {
            string resultado = $"{7}+{3}={soma(3,7)}\n{7}x{3}={multiplicacao(7,3)}\n{7}/{3}={divisao(7,3)}\n{7}-{3}={subtracao(7,3)}\n";

            Console.WriteLine(resultado);
        }  
    }

    public class Sensor
    {
        // declara o delegate do evento
        public delegate void DelegadoParaEventoSensor(object sender, EventArgs e);

        // declara o evento da classe sensor
        public event DelegadoParaEventoSensor SensorAtivado;

        // método que dispara o evento.
        public void Disparador()
        {
            Console.WriteLine("Evento do sensor disparado.");

            if (SensorAtivado != null)
            {
                SensorAtivado(this, EventArgs.Empty);
            }
        }
    }

    // observer
    public class Controlador
    {
        // método com mesma assinatura do evento; esse método será inscrito no evento.
        public void MetodoInscritoNoEvento(object sender, EventArgs e)
        {
            Console.WriteLine("Evento captado com sucesso.");
        }
    }
}
