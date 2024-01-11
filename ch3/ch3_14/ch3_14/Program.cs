namespace ch3_14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char x1 = 'A';
            char x2 = '\x0042';
            char x3 = '\u0043';
            char x4 = '\x44';
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", x1, x2, x3, x4);
            Console.WriteLine("{0} {1} \n{2} {3}", x1, x2, x3, x4);
            Console.WriteLine("{0} {1} \u000A{2} {3}", x1, x2, x3, x4);
            Console.WriteLine("{0} {1} \r\n{2} {3}", x1, x2, x3, x4);
            Console.WriteLine("{0} {1} \u000D\u000A{2} {3}", x1, x2, x3, x4);
        }
    }
}

