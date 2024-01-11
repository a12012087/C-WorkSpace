namespace ch5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 35;
            b = a & 7;
            Console.WriteLine($" a & 7 (10進位) = {b}");
            a &= 7;
            b = a;
            Console.WriteLine($" a & 7 (10進位) = {b}");
            }
    }
}