namespace Sample507
{
    public class Super
    {
        private int param = 0;

        public Super()
        {
            Console.WriteLine($"Superクラスのコンストラクタ（引数なし）");
        }

        public Super(int param)
        {
            Console.WriteLine($"Superクラスのコンストラクタ（引数: param={param}）");
            this.param = param;
        }

        ~Super()
        {
            Console.WriteLine($"Superクラスのデストラクタ");
        }

        public void ShowParam()
        {
            Console.WriteLine($"param = {param}");
        }
    }
}
