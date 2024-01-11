namespace ch4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===ch4_11===");
            int a, c, d;
            a = 3;
            c = 2;
            a *= c;
            Console.WriteLine($"a *= c : {a}");
            a = 3;
            d = 4;
            a *= c + d;
            Console.WriteLine($"a *= c + d : {a}");
            Console.WriteLine("===ch4_11-1===");
            int? x = null;
            int? y = 5;
            Console.WriteLine($"x = {x ??= 0}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y ??= 0}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine("===ch4_11-2===");
            int? x1 = null;
            int? y1 = 5;
            int? z1, z2;
            z1 = x1 ?? 0;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"z1 = {z1}");
            z2 = y1 ?? 0;
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z2 = {z2}");
        }
    }
}