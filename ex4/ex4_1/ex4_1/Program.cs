namespace ex4_1
{
    class Program
    {
        static void Main(string[] args)
        {
           //計算一天工作8小時，時薪是160元，一年工作300天，計算可以賺多少錢。
           int workHour = 8;
           int hourSalary = 160;
           int workDay = 300;
           int yearSalary = workHour * hourSalary * workDay;
           Console.WriteLine("一年可累積收入:"+yearSalary);
           //如果是每個月花費是9000元，請計算每年可以儲存多少錢。
           int monthCost = 9000;
           int saveMoney = yearSalary - monthCost * 12;
           Console.WriteLine("每年可儲存收入:"+saveMoney);
        }
    }
}

