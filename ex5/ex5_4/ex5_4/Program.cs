namespace ex5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = a >> 3;
            Console.WriteLine($"a >> 3 的(2進位)  = {Convert.ToString(b,2)}");
            Console.WriteLine($"a >> 3 的(8進位)  = {Convert.ToString(b,8)}");
            Console.WriteLine($"a >> 3 的(10進位) = {Convert.ToString(b,10)}");
            Console.WriteLine($"a >> 3 的(16進位) = {Convert.ToString(b,16)}");
        }
    }
}

