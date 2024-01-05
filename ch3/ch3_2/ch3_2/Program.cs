namespace ch3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3;
            x1 = 2147483647;
            x2 = x1 + 1;
            x3 = x1 - 1;
            //了解整數的溢出
            System.Console.WriteLine("x1={0}", x1);
            System.Console.WriteLine("x2={0}", x2);
            System.Console.WriteLine("x3={0}", x3);
            System.Int32 x4 = 10;
            Console.WriteLine("x4={0}", x4);
        }
    }
}