namespace ch5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 7;
            b = a << 1;
            Console.WriteLine($"a 的 (2進位)   = {Convert.ToString(a, 2)}");
            Console.WriteLine($"a << 1 (2進位) = {Convert.ToString(b, 2)}");
            b = a << 3;
            Console.WriteLine($"a << 3 (2進位) = {Convert.ToString(b, 2)}");

            uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"x      = {Convert.ToString(x, 2)} ");
            uint y = x << 4;
            Console.WriteLine($"x << 4 = {Convert.ToString(x, 2)} ");
        }
    }
}