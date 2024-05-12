namespace hello_world
{
    public class AlgoritmoEuclides
    {
        public void Euclides(int x, int y)
            {
                int q = x/y;
                int r = y/x;

                do
                {
                    q = x/y;
                    r = y/x;
                    System.Console.WriteLine($"{x} = {y}x{q} + {r}");
                    x = y;
                    y = r;
                } while (true);
            }
    }

}