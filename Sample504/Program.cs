namespace Sample504
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"角度の入力：");
            double angle = double.Parse(Console.ReadLine());
            double rad = Math.PI * angle / 180.0;
            Console.WriteLine($"sin{angle}= {Math.Sin(rad)}");
            Console.WriteLine($"cos{angle}= {Math.Cos(rad)}");
            Console.WriteLine($"tan{angle}= {Math.Tan(rad)}");
        }
    }
}
