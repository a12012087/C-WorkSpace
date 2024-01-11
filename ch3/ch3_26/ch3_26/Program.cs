namespace ch3_26
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new
            {
                ID = 1,
                Name = "Lie-Qing-Der",
                Score = new { Math = 90, English = 80, Chinese = 70 }
            };
            var sum = stu.Score.Math + stu.Score.English + stu.Score.Chinese;
            Console.WriteLine($"ID: {stu.ID}, Name: {stu.Name}, Sum: {sum}");
            Console.WriteLine("各科成績如下:");
            Console.WriteLine($"Math: {stu.Score.Math}, English: {stu.Score.English}, Chinese: {stu.Score.Chinese}");
        }
    }
}