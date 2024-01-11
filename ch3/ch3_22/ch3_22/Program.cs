namespace ch3_22
{
    class Program
    {
        static void Main(string[] args)
        {
            byte by = 123;
            int x = by + 1;
            Console.WriteLine($"x= {x}");
            short sh = 18;
            x = sh;
            Console.WriteLine($"x= {x}");
            char ch = 'A';
            x = ch;
            Console.WriteLine($"x= {x}");
        }
    }
}