using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator c = new Calculator();
            //Console.WriteLine("Add: " + c.Add(3, 4));

            IAdd add = new Calculator();
            Console.WriteLine("Add: " + add.Add(3, 4));

            IAddDupe addDupe = new Calculator();
            Console.WriteLine("Add: " + addDupe.Add(3, 4));

            /*Console.WriteLine("Subtract: " + c.Subtract(3, 4));
            Console.WriteLine("Multiply: " + c.Multiply(3, 4));
            Console.WriteLine("Divide: " + c.Divide(3, 4));
            Console.WriteLine("Modular: " + c.Modular(3, 4));
            Console.WriteLine("Modular: " + c.bitwiseAnd(3, 4));

            //Interface boxing
            
            
            IAdd add = new Calculator();
            Console.WriteLine("Add: " + add.Add(3, 4));

            //ICalculator calculator = new Calculator();
            ICalculator calculator = c;         
            Console.WriteLine("Subtract: " + calculator.Subtract(3, 4));
            Console.WriteLine("Multiply: " + calculator.Multiply(3, 4));
            Console.WriteLine("Divide: " + calculator.Divide(3, 4));
            Console.WriteLine("Modular: " + calculator.Modular(3, 4));*/
        }
    }
}
