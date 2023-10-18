// See https://aka.ms/new-console-template for more information
using System.Linq;

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
    Vetores
 */
int[] primos = {2, 3, 5, 7, 11, 13, 17};
string[] matematicos = new string[4]{"Gauss", "Ramanujan", "Euler", "Arquimedes"};
string[] fisicos = new string[4];
fisicos = new string[] {"Newton", "Born", "Ludwig", "Maxwell"};



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
Console.WriteLine($"{primos}\n{matematicos}\n{fisicos}");
int a = 1;
foreach (int id in primos)
{
    Console.WriteLine($"{a}° elemento: {id}");
    a++;
}
Console.WriteLine($"Maior: {primos.Max()}\nMenor: {primos.Min()}\nMédia: {primos.Average()}\nSoma: {primos.Sum()}\nQuantidade: {primos.Count()}");