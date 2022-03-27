namespace Sample506
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();

            c1.Num1 = 1;
            c1.Num2 = 3;
            c1.Add();
            c1.Sub();

            ExCalculator c2 = new ExCalculator();

            c2.Num1 = 10;
            c2.Num2 = 3;
            c2.Add();
            c2.Sub();
            c2.Mul();
            c2.Div();
        }
    }
}
