using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyCalc
    {
        public double Sum(double x,double y)
        { return x + y; }
        public double Sub(double x, double y)
        { return x - y; }
        public double Mul(double x, double y)
        { return x * y; }
        public double Div(double x, double y)
        {
            if (y==0)
            {
                throw new DivideByZeroException("Impossible to divide");
            }
            return x / y;
        }
    }
}
