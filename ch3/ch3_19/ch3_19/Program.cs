namespace ch3_19
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dyVar = 50;
            Console.WriteLine($"值 : {dyVar,-10}, 型別 : {dyVar.GetType()}");
            
            dyVar = "DeepMind";
            Console.WriteLine($"值 : {dyVar,-10}, 型別 : {dyVar.GetType()}");
            
            dyVar = true;
            Console.WriteLine($"值 : {dyVar,-10}, 型別 : {dyVar.GetType()}");
        }
    }
}