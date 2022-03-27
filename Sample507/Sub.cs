namespace Sample507
{
    public class Sub : Super
    {
        public Sub()
        {
            Console.WriteLine($"Subクラスのコンストラクタ（引数なし）");
        }

        public Sub(int param) : base(param)
        {
            Console.WriteLine($"Subクラスのコンストラクタ（引数: param={param}）");
        }

        ~Sub()
        {
            Console.WriteLine($"Subクラスのデストラクタ");
        }
    }
}
