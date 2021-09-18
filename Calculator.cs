using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    //class Calculator : ICalculator, IAdd //Multiple interface inheritance
    class Calculator : IAdd, IAddDupe
    {
         int IAdd.Add(int a, int b)
        {
            Console.WriteLine("In IAdd method");
            return a + b;
        }

         int IAddDupe.Add(int a, int b)
        {
            Console.WriteLine("In IAddDupe method");
            return a + b;
        }
        /* public int Subtract(int a, int b)
         {
             return a - b;
         }
         public int Multiply(int a, int b)
         {
             return a * b; 
         }
         public int Divide(int a, int b)
         {
             return a / b;
         }
         public int Modular(int a, int b)
         {
             return a % b; 
         }
         public int bitwiseAnd(int a , int b)
         {
             return a & b;
         }*/

    }
}
