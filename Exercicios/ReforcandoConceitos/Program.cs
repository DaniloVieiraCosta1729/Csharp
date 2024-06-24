using ReforcandoConceitos;
using System.Net.NetworkInformation;
using System.Threading.Channels;

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

//EventoRelogio.Main();

//const string uriString = "https://learn.microsoft.com/en-us/dotnet/path?key=value#bookmark";

//Uri objUri = new Uri(uriString);

//Console.WriteLine(objUri.Host);
//Console.WriteLine(objUri.PathAndQuery);
//Console.WriteLine(objUri.Fragment);

//NetworkChange.NetworkAddressChanged += OnNetworkAddressChanged;

//static void OnNetworkAddressChanged(
//    object? sender, EventArgs args)
//{
//    foreach ((string name, OperationalStatus status) in
//        NetworkInterface.GetAllNetworkInterfaces()
//            .Select(networkInterface =>
//                (networkInterface.Name, networkInterface.OperationalStatus)))
//    {
//        Console.WriteLine(
//            $"{name} is {status}");
//    }
//}

//Console.WriteLine(
//    "Listening for address changes. Press any key to continue.");
//Console.ReadLine();

//NetworkChange.NetworkAddressChanged -= OnNetworkAddressChanged;

//Action<int> falar;
//falar = Console.WriteLine;

//falar(Delegates.mais(2, 3));

//Delegates.mais += Delegates.Subtrai;

//falar(Delegates.mais(2, 3));

//Delegates.UniaoTexto concatenacao = delegate(string a, string b) { return $"{a} {b}"; };

//Console.WriteLine(concatenacao("Hello,","World."));

//Delegates.JuntaTipos<string, int, string> NumeroTexto = delegate (string a, int b) { return $"{a} {b}"; };

//string resultado = NumeroTexto("Número: ", 3);

//Console.WriteLine(resultado);

Delegates.Func<double, double, int> SomaInteira = (double a, double b) => (int)(a + b);

Console.WriteLine(SomaInteira(3.14,2.71));

Delegates.Func<int, string, bool> Q = (int a, string b) => ($"{a}" == $"{b}");

Console.WriteLine( Q(3, "3"));