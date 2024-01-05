namespace ch3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte的長度為{sizeof(byte)}");
            Console.WriteLine($"short的長度為{sizeof(short)}");
            Console.WriteLine($"int的長度為{sizeof(int)}");
            Console.WriteLine($"uint的長度為{sizeof(uint)}");
            Console.WriteLine($"long的長度為{sizeof(long)}");
            Console.WriteLine($"ulong的長度為{sizeof(ulong)}");
            Console.WriteLine($"=============================");
            Console.WriteLine($"float的最大值為{float.MaxValue}");
            Console.WriteLine($"float的最小值為{float.MinValue}");
            Console.WriteLine($"double的最大值為{double.MaxValue}");
            Console.WriteLine($"double的最小值為{double.MinValue}");
            Console.WriteLine($"decimal的最大值為{decimal.MaxValue}");
            Console.WriteLine($"decimal的最小值為{decimal.MinValue}");
        }
    }
}
