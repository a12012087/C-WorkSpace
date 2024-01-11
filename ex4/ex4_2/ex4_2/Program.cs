namespace ch4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, x, y, z;
            x = 10;
            y = 18;
            z = 5;
            a = x + y;
            b = 2 * x + 3 - z;
            c = y * z + 20 / y;
            d = -x + z - 3;
            Console.WriteLine("a = {0}\nb = {1}\nc = {2}\nd = {3}", a, b, c, d);
        }
    }
}