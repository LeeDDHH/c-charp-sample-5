namespace Sample510
{
    class Crow : Bird
    {
        public Crow() : base("カラス")
        {

        }

        public override void Sing()
        {
            Console.WriteLine($"カーカー");
        }
    }
}
