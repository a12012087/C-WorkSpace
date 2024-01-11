namespace ch3_25
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu = new { ID = "A001", Name = "Lie-Qind-Der" };
            var score = new { Math = 80, Physics = 92, English = 90 };
            var sum = score.Math + score.Physics + score.English;
            Console.WriteLine("學號:{0}, 姓名:{1}, 總分:{2}", stu.ID, stu.Name, sum);
        }
    }
}