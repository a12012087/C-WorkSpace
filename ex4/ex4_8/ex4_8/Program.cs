namespace ex4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi;
            pi = 4 * (1 - 1.0 / 3 + 1.0 / 5 - 1.0 / 7 + 1.0 / 9 - 1.0 / 11);
            pi = 4 * (1 - 1.0 / 3 + 1.0 / 5 - 1.0 / 7 + 1.0 / 9 - 1.0 / 11 + 1.0 / 13);
            Console.WriteLine($"pi的值為4*(1-1/3+1/5-1/7+1/9-1/11) = {pi}");
            Console.WriteLine($"pi的值為4*(1-1/3+1/5-1/7+1/9-1/11+1/13) = {pi}");
        }
    }
}