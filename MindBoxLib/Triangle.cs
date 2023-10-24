using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(string figure, double a, double b, double c) : base(figure)
        {
            if (a < 0 || b < 0 || c < 0) throw new ArgumentException(
                $"Error: Сторона не может быть меньше 0");
            else if (a > (b + c) || b > (a + c) || c > (a + b)) throw new ArgumentException(
                $"Error: Ваша сторона больше, чем сумма двух других сторон");
            else
                A = a;
                B = b;
                C = c;
        }
        public override double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 1);
        }
        public bool isRectangular() => (
                   Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)
                || Math.Pow(B, 2) == Math.Pow(C, 2) + Math.Pow(A, 2)
                || Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)
            );
    }
}
