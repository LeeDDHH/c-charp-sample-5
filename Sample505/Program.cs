namespace Sample505
{
    class Program
    {
        static void Main(string[] args)
        {
            Bingo sheet = new Bingo();
            Console.Write("ビンゴのマスの縦・横のサイズを入力：");
            int size = int.Parse(Console.ReadLine());
            sheet.Init(size);
            sheet.Show();
        }
    }
}
