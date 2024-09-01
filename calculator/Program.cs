namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator calc = new calculator();

            Console.WriteLine("Bitte geben Sie den ersten Wert ein:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie den zweiten Wert ein:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition: " + calc.Add(a, b));
            Console.WriteLine("Subtraktion: " + calc.Subtract(a, b));
            Console.WriteLine("Multiplikation: " + calc.Multiply(a, b));
            Console.WriteLine("Division: " + calc.Divide(a, b));

            
        }
    }
}
