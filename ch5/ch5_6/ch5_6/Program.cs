namespace ch5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = -7;
            b = ~a;
            Console.WriteLine($"a 的 1 補數(10進位) = {b}");
            Console.WriteLine($"a 的 1 補數(16進位) = {Convert.ToString(b, 16)}");
            uint x = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint y = ~x;
            Console.WriteLine($"x = {Convert.ToString(x, 2)}");
            Console.WriteLine($"y = {Convert.ToString(y, 2)}");
        }
    }
}\