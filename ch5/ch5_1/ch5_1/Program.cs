namespace ch5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine($"{x}的2進位 : {Convert.ToString(x, 2)}");
            Console.WriteLine($"{x}的2進位 : {Convert.ToString(x, toBase:2)}");
            Console.WriteLine($"{x}的8進位 : {Convert.ToString(x, 8)}");
            Console.WriteLine($"{x}的8進位 : {Convert.ToString(x, toBase:8)}");
            Console.WriteLine($"{x}的16進位 : {Convert.ToString(x, 16)}");
            Console.WriteLine($"{x}的16進位 : {Convert.ToString(x, toBase:16)}");
        }
    }
}