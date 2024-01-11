namespace ch3_11
{
    public class Program
    {
        public static void Main(string[] args)
        {
          double x = 0.0/0.0;
          Console.WriteLine(x);
          Console.WriteLine(Double.NaN);
          
          double inf = 5.0/0.0;
          Console.WriteLine(inf);
          Console.WriteLine(double.PositiveInfinity);
          
          double ninf = -5.0/0.0;
          Console.WriteLine(ninf);
          Console.WriteLine(double.NegativeInfinity);
        }
    }
}