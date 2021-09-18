using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    interface ICalculator
    {
        int Subtract(int a, int b);

        int Multiply(int a, int b);

        int Divide(int a, int b);

        int Modular(int a, int b);

    }
}
