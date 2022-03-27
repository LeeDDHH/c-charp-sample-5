namespace Sample510
{
    class Program
    {
        static void Main(string[] args)
        {
            Crow c = new Crow();
            Sparrow s = new Sparrow();
            Console.Write($"{c.Name}: ");
            c.Sing();
            Console.Write($"{s.Name}: ");
            s.Sing();
        }
    }
}
