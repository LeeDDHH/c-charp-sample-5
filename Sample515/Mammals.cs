namespace Sample515
{
    abstract class Mammals
    {
        protected string name = "";
        public abstract void Bark();

        public void ShowName()
        {
            Console.WriteLine($"名前：{name}");
        }
    }
}
