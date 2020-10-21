using System;

namespace Calc_Deleg
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.Calculator('+', 3, 5);
        }
    }
}
