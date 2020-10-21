using System;
using System.Collections.Generic;
using System.Text;

namespace Calc_Deleg
{
    class Calc
    {
        Func<double, double, double> func;
        public double Plus(double a,double b)
        {
            return a + b;
        }
        public double Minus(double a, double b)
        {
            return a - b;
        }
        public double Mult(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            return a /b;
        }
        public void Calculator(char s,double a,double b)
        {
            switch (s)
            {
                case '+':
                    func = Plus;
                    Console.WriteLine( func(a,b));
                    break;
                case '-':
                    func = Minus;
                    Console.WriteLine( func(a,b));
                    break;
                case '*':
                    func = Mult;
                    Console.WriteLine(func(a,b));
                    break;
                case '/':
                    func = Division;
                    Console.WriteLine(func(a,b));
                    break;
            }
        }
    }
}
