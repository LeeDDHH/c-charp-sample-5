namespace Sample506
{
    class ExCalculator : Calculator
    {
        public void Mul()
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        public void Div()
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
    }
}
