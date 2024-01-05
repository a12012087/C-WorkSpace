namespace ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            for (int i = 1; i <= row; i++) {
                for (int j = 1; j <= row-i; j++) //解決開頭的空格
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1; k++)//解決星星的數量，每一排要遞增2*
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
        }
    }
}

