namespace ex4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = y = z = 5;
            Console.WriteLine($"x = {x += y + z++}");
            x = y = z = 5;
            Console.WriteLine($"x = {x += y + ++z}");
        }
    }
}