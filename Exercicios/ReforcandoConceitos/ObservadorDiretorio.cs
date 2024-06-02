using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReforcandoConceitos
{
    public class ObservadorDiretorio
    {
        // usando o delegate pronto do .NET para trabalhar com diretórios para declarar um evento.
        public event EventHandler<FileSystemEventArgs> ArquivoCriado;

        // campo do tipo FileSystemWatch
        private readonly FileSystemWatcher _watcher;

        // construtor
        public ObservadorDiretorio(string path)
        {
            // inicializa o campo _watcher como um objeto FileSystemWatcher(path)
            _watcher = new FileSystemWatcher(path)
            {
                // inicializa a propriedade ModifyFilter de FileSystemWatcher.
                NotifyFilter = NotifyFilters.FileName
            };

            // inscreve uma função anônima que chama o método responsável por disparar o evento.
            _watcher.Created += (sender, e) => OnFileCreated(e);
            _watcher.EnableRaisingEvents = true; // permite que a pasta seja monitorada.
        }

        public virtual void OnFileCreated(FileSystemEventArgs e)
        {
            ArquivoCriado?.Invoke(this, e);
        }
    }
}
