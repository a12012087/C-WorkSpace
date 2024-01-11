namespace ch3_21
{
    public class Program
    {
        public static void Main(string[] args)
        {
           int x1 = default(int);
           double x2 = default(double);
           char x3 = default(char);
           bool x4 = default(bool);
           string x5 = default(string);
           object x6 = default(object);
           Console.WriteLine("int 預設值 = {0}", x1);
           Console.WriteLine("double 預設值 = {0}", x2);
           Console.WriteLine("char 預設值 = {0}", x3);
           Console.WriteLine("bool 預設值 = {0}", x4);
           Console.WriteLine("string 預設值 = {0}", x5);
           Console.WriteLine("object 預設值 = {0}", x6);
        }
    }
}

