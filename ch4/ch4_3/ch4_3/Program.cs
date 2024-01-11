namespace ch4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, a, b, c;
            a = 5;
            b = 4;
            c = 3;
            s = a * b % c;
            System.Console.WriteLine($"s = a * b % c = {s}");
            s = a * b / c;
            System.Console.WriteLine($"s = a * b / c = {s}");
        }
    }
}