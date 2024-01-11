namespace ch5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 32;
            b = a | 3;
            Console.WriteLine($"a | 3(10進位) = {b}");
            b |= 7;
            Console.WriteLine($"b | 7(10進位) = {b}");
            uint x = 0b_1010_0000;
            uint y = 0b_1001_0001;
            uint z = x | y;
            Console.WriteLine($"x     = {Convert.ToString(x, 2)}");
            Console.WriteLine($"y     = {Convert.ToString(y, 2)}");
            Console.WriteLine($"x | y = {Convert.ToString(z, 2)}");
        }
    }
}