
Euclides(1001,109);


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