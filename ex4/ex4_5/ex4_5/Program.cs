namespace ex4_5
{
    class Program
    {
        static void Main(string [] args)
        {
            int count = 100;
            int stuCount = 23;
            int supplyDays = 100 / 23;
            int overage = 100 % 23;
            Console.WriteLine($"蘋果可以吃{supplyDays}天\n第{supplyDays + 1}天會產生蘋果不足\n蘋果會不足{23-overage}顆");
        }
    }
}

