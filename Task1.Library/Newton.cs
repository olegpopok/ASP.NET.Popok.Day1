using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public static class Newton
    {
        private const double epsilon = 0.000001;

        public static double Radical(double value, int n)
        {
           return  Radical(value, n, epsilon);
        }

        public static double Radical(double value, int n, double epsilon)
        {
            if ((value < 0 && n % 2 == 0) || epsilon < 0)
            {
                throw new ArgumentException();
            }

            double xPrev, xNext = 1;

            do
            {
                xPrev = xNext;
                xNext = xPrev - Function(value, xPrev, n) / DerivativeOfFunction(xPrev, n);
            } while (System.Math.Abs(xNext - xPrev) > epsilon);

            return xNext;
        }

        private static double Function(double a, double x, int n)
        {
            double xn = 1;

            while (n > 0)
            {
                xn *= x;
                n--;
            }
            
            return xn - a;
        }

        private static double DerivativeOfFunction(double x, int n)
        {
            double result = n;

            while (n > 0)
            {
                result *= x;
                n--;
            }

            return result;
        }
    }
}
