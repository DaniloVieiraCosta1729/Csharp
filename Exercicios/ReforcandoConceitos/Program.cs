using ReforcandoConceitos;
/*
EventoBotao botao = new EventoBotao();

botao.BotaoPressionado += (object sender, CustomEventArgsBotao e) => { Console.WriteLine($"A tecla {e.Botao} foi pressionada no teclado {e.Teclado}."); };

botao.OnBottonPressed();
*/

string path = @"D:\Física\Física clássica";

ObservadorDiretorio fisica = new ObservadorDiretorio(path);
fisica.ArquivoCriado += (sender, e) => { Console.WriteLine($"O arquivo: {e.Name}, foi criado."); };

Console.ReadLine();

string path2 = @"D:\Matematica\Análise\Resumo.txt";

if (!File.Exists(path2))
{
    using (StreamWriter escritor = File.CreateText(path2))
    {
        escritor.WriteLine("Esse arquivo foi escrito utilizando recursos do DotNET que implementam a interface IDisposable.");
        escritor.WriteLine("Isso é feito dentro de um bloco using () { }, porque o using sempre libera os recursos do sistema que não são gerenciados após o fim do seu bloco. Isso ajuda a prevenir problemas de vazamento de recursos.");
    }
}