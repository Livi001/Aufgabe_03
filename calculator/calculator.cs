using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class calculator
    {
        // Intern gespeicherter Zustand
        private int lastResult = 0;

        // Methode für Addition
        public int Add(int a, int b)
        {
            lastResult = a + b;
            return lastResult;
        }

        // Methode für Subtraktion
        public int Subtract(int a, int b)
        {
            lastResult = a - b;
            return lastResult;
        }

        // Methode für Multiplikation
        public int Multiply(int a, int b)
        {
            lastResult = a * b;
            return lastResult;
        }

        // Methode für Division
        public int Divide(int a, int b)
        {
            lastResult = a / b;
            return lastResult;
        }
        // Methode für Addition mit einem Parameter
        public int Add(int a)
        {
            lastResult = lastResult + a;
            return lastResult;
        }

        // Methode für Subtraktion mit einem Parameter
        public int Subtract(int a)
        {
            lastResult = lastResult - a;
            return lastResult;
        }

        // Methode für Multiplikation mit einem Parameter
        public int Multiply(int a)
        {
            lastResult = lastResult * a;
            return lastResult;
        }

        // Methode für Division mit einem Parameter
        public int Divide(int a)
        {
            lastResult = lastResult / a;
            return lastResult;
        }
    }


}





