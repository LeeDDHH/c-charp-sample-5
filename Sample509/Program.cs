namespace Sample509
{
    class Program
    {
        public void Foo()
        {
            Console.WriteLine($"Foo");
        }
        static void Main(string[] args)
        {
            Program s1 = new Program();
            Program s2 = s1;
            Console.WriteLine($"{s1.ToString()}");
            Console.WriteLine($"{s1.Equals(s2)}");
            Console.WriteLine($"{s1.GetType()}");
            Console.WriteLine($"{s1.GetHashCode()}");
            Console.WriteLine($"{s1.MemberwiseClone()}");
        }
    }
}
