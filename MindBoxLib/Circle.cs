using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(string figure, double radius) : base(figure)
        {
            Radius = radius;
        }
        public override double Square() =>  Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
    }
}
