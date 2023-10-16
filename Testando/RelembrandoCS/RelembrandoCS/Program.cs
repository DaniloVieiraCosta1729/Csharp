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

// Display
Console.WriteLine(nome+" tem "+idade+" anos.");
Console.WriteLine($"{honorifico} {primeiroNome} tem {idadeMaria} anos.");
Console.WriteLine($"O número binário 1101 na base dez é {binario}");
Console.WriteLine($"O número hexadecimal A2 em decimal é {hexadecimal}");
Console.WriteLine($"==============================================================================");
Console.WriteLine($"Byte i = {i}, int j = {j}, float = {f}");
Console.WriteLine($"Float g = {g}, int i2 = {i2}, short j2 = {j2}");