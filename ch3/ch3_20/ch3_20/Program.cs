namespace ch3_20
{
    public class Program
    {
        public static void Main(string[] args)
        {
            dynamic dyVar = 5;
            int i = dyVar;
            System.Console.WriteLine($"i:{i.GetType()}, dyVar:{dyVar.GetType()}");

            dyVar = "C# and Python";
            string s = dyVar;
            System.Console.WriteLine($"s:{s.GetType()}, dyVar:{dyVar.GetType()}");
        }
    }
}