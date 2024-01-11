namespace ch5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 31;
            b = 63;
            Console.WriteLine($"a ^ b (10進位) = {a ^ b}");
            uint x = 0b_1111_1000;
            uint y = 0b_0001_1100;
            uint z = x ^ y;
            Console.WriteLine($"x      = {Convert.ToString(x, 2)}");
            Console.WriteLine($"y      = {Convert.ToString(y, 2)}");
            Console.WriteLine($"x| y   = {Convert.ToString(z, 2)}");
        }
    }
}