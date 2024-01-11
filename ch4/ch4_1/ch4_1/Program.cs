namespace ch4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, a, b;
            a = 10;
            b = 20;
            s = a + b;
            Console.WriteLine($"s = a + b = {s}");
            a = (int)1.8;
            b = (int)2.3;
            s = a - b;
            Console.WriteLine($"s = a - b = {s}");
            a = 5;
            b = 6;
            s = a * b; 
            Console.WriteLine($"s = a * b = {s}");
            a = (int)2.4;
            b = (int)1.1;
            s = a / b;  
            Console.WriteLine($"s = a / b = {s}");
            a = 5;
            b = 4;
            s = a % b;
            Console.WriteLine($"s = a % b = {s}");
        }
    }
}