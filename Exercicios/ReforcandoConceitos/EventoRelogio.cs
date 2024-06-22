using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ReforcandoConceitos
{
    public class EventoRelogio
    {
        private static System.Timers.Timer _temporizador = new System.Timers.Timer();
        private static int segundos = 1;

        public static void Main()
        {
            _temporizador.Interval = 1000;
            _temporizador.Elapsed += MarcadorDoTempo;

            _temporizador.Start();
            Console.ReadLine();
            _temporizador.Stop();
            Console.ReadLine();
            _temporizador.Start();
            Console.ReadLine();
            _temporizador.Stop();

            _temporizador.Dispose();
            Console.WriteLine("Fim do Programa.");
        }

        private static void MarcadorDoTempo(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine($"Se passou {segundos} s");
            segundos++;
        }
    }
}
