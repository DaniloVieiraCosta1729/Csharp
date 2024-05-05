// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine(@"
░█████╗░░█████╗░██████╗░  ██╗███╗░░██╗  ░█████╗░░░░██╗░██╗░
██╔══██╗██╔══██╗██╔══██╗  ██║████╗░██║  ██╔══██╗██████████╗
██║░░██║██║░░██║██████╔╝  ██║██╔██╗██║  ██║░░╚═╝╚═██╔═██╔═╝
██║░░██║██║░░██║██╔═══╝░  ██║██║╚████║  ██║░░██╗██████████╗
╚█████╔╝╚█████╔╝██║░░░░░  ██║██║░╚███║  ╚█████╔╝╚██╔═██╔══╝
░╚════╝░░╚════╝░╚═╝░░░░░  ╚═╝╚═╝░░╚══╝  ░╚════╝░░╚═╝░╚═╝░░░
");

// Vamos instanciar um objeto da classe produto:
Produtos p1 = new Produtos("Maçã", 2.3f);
Produtos p2 = new Produtos("Pêra", 3.5f);
Produtos p3 = new Produtos(50);
p3.Nome = "Laranja";
p3.Preco = 1.2f;
Console.WriteLine($"Produto: {p1.Nome} -- Preço: R$ {p1.Preco:F2}");
Console.WriteLine($"Produto: {p2.Nome} -- Preço: R$ {p2.Preco:F2}");
Console.WriteLine($"Produto: {p3.Nome} -- Preço: R$ {p3.Preco:F2}");

p1.Comprar(42);
p2.Comprar(23);
p2.Vender(2);

List<Produtos> produtos = new List<Produtos> { p1, p2, p3};

foreach (Produtos item in produtos)
{
    item.Comprar(100);
    Console.WriteLine(item.DetalhesDoProduto());
}