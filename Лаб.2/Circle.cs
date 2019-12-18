using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб._2
{
    public class Circle : Figure, IPrint
    {
        public Circle(double a)
        {
            radius = a;
            Area = area();
        }
        public Circle()
        {
            radius = 1;
            Area = area();
        }
        public double radius { get; set; }
        public override double area()
        {
            Area = radius * radius * Math.PI;
            return Area;
        }
        public override string ToString()
        {
            return "Фигура круг: " + "радиус - " + radius.ToString() + ", площадь - " + area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
