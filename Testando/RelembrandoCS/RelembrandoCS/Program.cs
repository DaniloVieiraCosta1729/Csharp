// See https://aka.ms/new-console-template for more information
// Variables

// Não inicializada
int idade;
idade = 44;
// Inicializada
string nome = "Gascoigne";
// Várias variáveis na mesma linha
string primeiroNome = "Maria", honorifico = "Lady";
// Constante
const int idadeMaria = 28;
// Binário
sbyte binario = 0b001101;
// Hexadecimal
ushort hexadecimal = 0xA2;

/*
    Conversões
 */

// Conversão implícita
byte i = 1;
int j = i;
float f = j;
// Conversão explícita
float g = 2.71828483f;
int i2 = (int)g;
short j2 = (short)i2;
// Detalhes sobre conversão
double d = 3.94159;
int i3 = (int)d; // Trunca 3.94159, resultado -> 3
int j3 = Convert.ToInt32(d); // Arredonda 3.14159 para inteiro, resultado -> 4

/*
    Tipagem automática
 */
// var
var inteiro = 5; //int
var texto = "Texto"; //string
var racional = 1.61803399; //double
var logico = (Math.Pow(4,2)==16); //bool
var caracter = 'C'; //char

/*
    Strings
 */
string textao = "Esse é um texto qualquer.";
int tamanho = textao.Length;
string maiusculas = textao.ToUpper();
string minusculas = textao.ToLower();
int where_is_e = textao.IndexOf("é");
string trecho = textao.Substring(0, where_is_e);
string tabulacao = "Coluna 1\t Coluna 2\t Coluna 3";


/*
    Estruturas de controle
 */
//Condicional
float pi = 3.1415169f;
float e = 2.71828182f;
Console.WriteLine($"e^pi = {Math.Pow(e, pi)}\npi^e = {Math.Pow(pi, e)}");
if (Math.Pow(pi,e) > Math.Pow(e, pi))
{
    Console.WriteLine("pi^e > e^pi");
} else if (Math.Pow(pi, e) < Math.Pow(e, pi))
{
    Console.WriteLine("e^pi > pi^e");
} else
{
    Console.WriteLine("e^pi = pi^e");
}

Random aleatorio = new Random();
int diasDaSemana = aleatorio.Next(1,8);
switch (diasDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;

    case 2: 
        Console.WriteLine("Segunda");
        break;

    case 3: 
        Console.WriteLine("Terça");
        break;

    case 4: 
        Console.WriteLine("Quarta");
        break;

    case 5:
        Console.WriteLine("Quinta");
        break;

    case 6:
        Console.WriteLine("Sexta");
        break;

    case 7:
        Console.WriteLine("Sábado");
        break;

    default: 
        Console.WriteLine("Inválido");
        break;
}

// Repetição
i = 1;
while (i < 5)
{
    Console.WriteLine(i);
    i += 1;
}

i = 1;

do
{
    Console.WriteLine(i);
    i += 1;
} while (i < 5);

for (int k = 0; k < 5; k++)
{
    Console.WriteLine(Math.Pow(k,2));
}

string[] tags = {"C#", ".NET", "VS Code"};
foreach (string tag in tags)
{
    Console.WriteLine(tag);
}

// Display
Console.WriteLine(nome+" tem "+idade+" anos.");
Console.WriteLine($"{honorifico} {primeiroNome} tem {idadeMaria} anos.");
Console.WriteLine($"O número binário 1101 na base dez é {binario}");
Console.WriteLine($"O número hexadecimal A2 em decimal é {hexadecimal}");
Console.WriteLine($"==============================================================================\n");
Console.WriteLine($"Byte i = {i}, int j = {j}, float = {f}");
Console.WriteLine($"Float g = {g}, int i2 = {i2}, short j2 = {j2}");
Console.WriteLine($"Double d = {d}, (int)d = {i3}, Convert.ToInt32(d) = {j3}.");
Console.WriteLine($"==============================================================================\n");
Console.WriteLine($"var inteiro = 5 -> {inteiro}; {inteiro.GetType()}" +
    $"\nvar texto = Texto -> {texto}; {texto.GetType()}\n" +
    $"var racional = 1.61803399 -> {racional}; {racional.GetType()}\n" +
    $"var logico = (Math.Pow(4,2)==16) -> {logico}; {logico.GetType()}\n" +
    $"var caracter = C -> {caracter}; {caracter.GetType()}\n");
Console.WriteLine($"==============================================================================\n");
Console.WriteLine($"texto: {textao};");
Console.WriteLine($"Em maiusculas: {maiusculas};");
Console.WriteLine($"Em minusculas: {minusculas};");
Console.WriteLine($"Posição da primeira aparição do caractere (é): {where_is_e};");
Console.WriteLine($"trecho de texto: {trecho};");
Console.WriteLine($"Tabulação: {tabulacao};");
