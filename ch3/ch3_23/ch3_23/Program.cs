namespace ch3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 12345.6789;
            int x = (int)d;
            Console.WriteLine("x = {0}", x);
            float f = 1234.567F;
            x = (int)f;
            Console.WriteLine("x = {0}", x);
        }
    }
}

