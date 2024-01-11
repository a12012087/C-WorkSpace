namespace ch4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, s ;
            i = 5;
            s = ++i + 3;
            Console.WriteLine($"s = ++i + 3 = {s};");
            i = 5; 
            s = 3 + i++;
            Console.WriteLine($"s = 3 + i++ = {s};");
        }
    }
}