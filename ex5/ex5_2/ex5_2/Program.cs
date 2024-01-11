namespace ex5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 77;
            int c = a & b;
            Console.WriteLine($"a & b (2進位)   = {Convert.ToString(c,2)}");
            Console.WriteLine($"a & b (8進位)   = {Convert.ToString(c,8)}");
            Console.WriteLine($"a & b (10進位)  = {Convert.ToString(c,10)}");
            Console.WriteLine($"a & b (16進位)  = {Convert.ToString(c,16)}");
        }
    }
}