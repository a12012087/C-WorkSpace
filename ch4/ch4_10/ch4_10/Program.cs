namespace ch4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            a += 9;
            Console.WriteLine($"a += 9: {a}");
            a -= 4;
            Console.WriteLine($"a -= 4: {a}");
            a *= 2;
            Console.WriteLine($"a *= 2: {a}");
            a /= 4;
            Console.WriteLine($"a /= 4: {a}");
            a %= 3;
            Console.WriteLine($"a %= 3: {a}");
        }
    }
}