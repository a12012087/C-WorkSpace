namespace ch4_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //假設圓柱半徑是20公分，高度是30公分，請計算此圓柱體的體積。
            const double PI = 3.14159;
            double radius = 20;
            double height = 30;
            double volume = radius * radius * height * PI;
            System.Console.WriteLine("圓柱體的體積:" + volume);
        }
    }
}

