namespace ex4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = y = z = 5;
            int a = (x -= ++y + z--);
            x = y = z = 5;
            int b = (x *= y - z--);
            x = y = z = 5;
            int c = (x /= 2 + y++ - z++);
            Console.WriteLine($"(a) x = {a}");
            Console.WriteLine($"(b) x = {b}");
            Console.WriteLine($"(c) x = {c}");
        }
    }
}

