using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReforcandoConceitos
{
    public class EventoBotao
    {
        // Delegate do Evento.
        public delegate void Acionamento(object sender, CustomEventArgsBotao e);

        // Evento.
        public event Acionamento BotaoPressionado;

        // Método que capta a tecla apertada.
        public void OnBottonPressed()
        {
            while (true)
            {
                char botao = Console.ReadKey(true).KeyChar;

                BotaoPressionado?.Invoke(this, new CustomEventArgsBotao { Botao = botao });
            }
        }
    }

    public class CustomEventArgsBotao : EventArgs
    {
        public char Botao { get; set; }
        public string Teclado { get; set; }

        public CustomEventArgsBotao()
        {
            Teclado = "T1";
        }
    }
}
