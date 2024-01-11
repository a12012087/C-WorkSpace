namespace ex4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, x;
            int y;
            x =  3.5;
            y = 4;
            a = x + y;
            b = 2 * x + 3 - y;
            c = y * y + 20 / y;
            d = -x + y - 3;
            Console.WriteLine("a = {0}\nb = {1}\nc = {2}\nd = {3}", a, b, c, d);
        }
    }
}