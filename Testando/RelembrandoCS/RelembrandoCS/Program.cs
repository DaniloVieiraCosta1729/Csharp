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
// Display
Console.WriteLine(nome+" tem "+idade+" anos.");
Console.WriteLine($"{honorifico} {primeiroNome} tem {idadeMaria} anos.");
Console.WriteLine($"O número binário 1101 na base dez é {binario}");
Console.WriteLine($"O número hexadecimal A2 em decimal é {hexadecimal}");
