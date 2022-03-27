namespace Sample502
{
    class Program
    {
        private static int snum = 100;

        public int inum = 200;

        public static void Foo()
        {
            Console.WriteLine("fooメソッド（staticメソッド）");
        }

        public void Bar()
        {
            Console.WriteLine("fooメソッド（インスタンスメソッド）");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine($"pのインスタンスフィールド: inum ={p.inum}");
            Console.WriteLine($"Programのクラスフィールド: snum ={snum}");
            Foo();
            p.Bar();
        }
    }
}
