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