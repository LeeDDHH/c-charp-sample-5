namespace Sample508
{
    class Child : Parent
    {
        public override void Foo()
        {
            // base.Foo();
            Console.WriteLine($"子クラスのFoo()メソッド");
        }
    }
}
