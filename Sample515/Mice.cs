namespace Sample515
{
    class Mice : Mammals
    {
        public Mice()
        { 
            this.name = "ねずみ";
        }

        public override void Bark()
        {
            Console.WriteLine($"チューチュー");
        }
    }
}
