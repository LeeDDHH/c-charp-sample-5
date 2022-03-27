namespace Sample515
{
    class Cat : Mammals
    {
        public Cat()
        {
            this.name = "猫";
        }

        public override void Bark()
        {
            Console.WriteLine($"にゃーにゃー");
        }
    }
}
