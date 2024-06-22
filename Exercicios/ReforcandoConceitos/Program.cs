using ReforcandoConceitos;

/*
EventoBotao botao = new EventoBotao();

botao.BotaoPressionado += (object sender, CustomEventArgsBotao e) => { Console.WriteLine($"A tecla {e.Botao} foi pressionada no teclado {e.Teclado}."); };

botao.OnBottonPressed();
*/

//string path = @"D:\Física\Física clássica";

//ObservadorDiretorio fisica = new ObservadorDiretorio(path);
//fisica.ArquivoCriado += (sender, e) => { Console.WriteLine($"O arquivo: {e.Name}, foi criado."); };

//Console.ReadLine();

//string path2 = @"D:\Matematica\Análise\Resumo.txt";

//if (!File.Exists(path2))
//{
//    using (StreamWriter escritor = File.CreateText(path2))
//    {
//        escritor.WriteLine("Esse arquivo foi escrito utilizando recursos do DotNET que implementam a interface IDisposable.");
//        escritor.WriteLine("Isso é feito dentro de um bloco using () { }, porque o using sempre libera os recursos do sistema que não são gerenciados após o fim do seu bloco. Isso ajuda a prevenir problemas de vazamento de recursos.");
//    }
//}
// =====================================================
//Delegates objetoQualquer = new Delegates();

//Func<int, int, int> maiorNumero = objetoQualquer.Maior;

//Func<float, float, float> maiorValor = objetoQualquer.Maior;

//int resultado1 = maiorNumero(3,10);

//float resultado2 = maiorValor(5.45f,1.2f);

//Action<int> mostrarInt = System.Console.WriteLine;
//Action<float> mostrarFloat = System.Console.WriteLine;

//mostrarInt(resultado1);
//mostrarFloat(resultado2);
// =====================================================

//Quadrado quadrado = delegate (int a) { return a * a; };

//mostrarInt(quadrado(9));

//public delegate int Quadrado(int inteiro);

// =====================================================
//Action<string> Falar = System.Console.Write;

//Paridade par = (a) => a % 2 == 0;

//Falar("Digite um número: ");
//int input = int.Parse(System.Console.ReadLine());

//string resultado = (par(input)) ? $"O número {input} é par" : $"O número {input} não é par.";

//Falar(resultado);

//public delegate bool Paridade(int numero);
// =====================================================

EventoRelogio.Main();
