using System;

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

            // Beispiel: Zweiter Durchlauf mit nur einem Parameter(verwendet das letzte Ergebnis)
            Console.WriteLine("Bitte geben Sie einen weiteren Wert ein:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition mit internem Zustand: " + calc.Add(c));
            Console.WriteLine("Subtraktion mit internem Zustand: " + calc.Subtract(c));
            Console.WriteLine("Multiplikation mit internem Zustand: " + calc.Multiply(c));
            Console.WriteLine("Division mit internem Zustand: " + calc.Divide(c));

        }
    }
}
