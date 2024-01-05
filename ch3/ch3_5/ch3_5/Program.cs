namespace ch3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0b_0011_0001;
            int x2 = 0B10_1110;
            int total;
            total = x1 + x2;
            Console.WriteLine("x1 = {0},\nx2 = {1},\ntotal = {2}", x1, x2, total);
            Console.WriteLine("==================================");
            int y1 = 1_000_111;
            int y2 = 5_333_666;
            total = y1 + y2;
            Console.WriteLine("y1 = {0},\ny2 = {1},\ntotal = {2}", y1, y2, total);
        }
    }
}

