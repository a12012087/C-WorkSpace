namespace ch5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 14;
            b = a >> 1;
            Console.WriteLine($"a 的 (2進位)    = {Convert.ToString(a, 2)}");
            Console.WriteLine($"a >> 1 (2進位)  = {Convert.ToString(b, 2)}");
            b = a >> 3;
            Console.WriteLine($"a >> 3 (2進位)  = {Convert.ToString(b, 2)}");

            uint x = 0b_1001;
            Console.WriteLine($"x     = {Convert.ToString(x, 2)}");
            uint y = x >> 2;
            Console.WriteLine($"x >>2 = {Convert.ToString(x, 2)}");
        }
    }
}