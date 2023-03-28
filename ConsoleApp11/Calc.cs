using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Calc
    {
        public static double Add(double a, double b) { return a + b; }
        public static double Divide(double a, double b) 
        { 
            if (b!=0.0) 
                return a / b; 

            throw new DivideByZeroException();
        }
    }
}
