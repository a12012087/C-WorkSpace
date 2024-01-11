namespace ch5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 77;
            int c = a & b;
            Console.WriteLine($"a     = {Convert.ToString(a, 2)}");
            Console.WriteLine($"b     = {Convert.ToString(b, 2)}");
            Console.WriteLine($"a & b = {Convert.ToString(c, 2)}");
            Console.WriteLine($"a & b ={c}");
            Console.WriteLine("=============================");
            uint x = 0b_1111_1000;
            uint y = 0b_1001_1101;
            uint z = x & y;
            Console.WriteLine($"x     = {Convert.ToString(x,2)}");
            Console.WriteLine($"y     = {Convert.ToString(y,2)}");
            Console.WriteLine($"z     = {Convert.ToString(z,2)}");
        }
    }
}