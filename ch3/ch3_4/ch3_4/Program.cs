namespace ch3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0b110001;
            int x2 = 0B1110;
            int total;
            total = x1 + x2;
            Console.WriteLine("x1 = {0},\nx2 = {1},\ntotal = {2}", x1, x2, total);
            Console.WriteLine("==================================");
            int y1 = 0x1A;
            int y2 = 0X20;
            total = y1 + y2;
            Console.WriteLine("y1 = {0},\ny2 = {1},\ntotal = {2}", y1, y2, total);
        }
    }
}

