
//Euclides(1001,109);
SomaDivisoresDeTres();


void Euclides(int x, int y)
{
    int q = x/y;
    int r = x%y;

    do
    {
        q=x/y;
        r=x%y;
        System.Console.WriteLine($"{x} = {y}x{q} + {r}");
        x = y;
        y = r;
    } while (r != 0);
}

void SomaDivisoresDeTres()
{
    int soma = 0;
    for (int i = 1; i <= 20; i++)
    {
        int incremento = i%3 == 0 ? i : 0;
        soma += incremento;
    }
    Console.WriteLine($"A soma dos divisores de 3 entre 1 e 20, incluindo os extremos, é {soma}.");
}