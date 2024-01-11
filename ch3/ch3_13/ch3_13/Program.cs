namespace ch3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            char x1 = 'A';
            char x2 = '\x0042';
            char x3 = '\u0043';
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
            Console.WriteLine("x3 = {0}", x3);
            char x4 = '\x44';
            Console.WriteLine("x4 = {0}", x4);  
            Console.WriteLine("{0}, {1}, {2}, {3}", x1, x2, x3, x4);
            Console.WriteLine("===================================");
            char x5 = '\u2605';
            char x6 = '\u2606';
            Console.WriteLine("x5 = {0}", x5);
            Console.WriteLine("x6 = {0}", x6);
        }
    }
}