namespace ex3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double radius = 10.0;
            Console.WriteLine("圓面積 : " + PI * radius * radius);
            Console.WriteLine("圓周長 : " + 2 * PI * radius);
        }
    }
}