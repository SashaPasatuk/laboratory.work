using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб._2
{
    public class Rectangle : Figure, IPrint
    {
        public Rectangle(double a, double b)
        {
            leight = a;
            width = b;
            Area = area();
        }
        public Rectangle(double a)
        {
            leight = a;
            width = a;
            Area = area();
        }
        public Rectangle()
        {
            leight = 1;
            width = 1;
            Area = area();
        }
        public double leight { get; set; }
        public double width { get; set; }
        public override double area()
        {
            Area = leight * width;
            return Area;
        }
        public override string ToString()
        {
            return "Фигура прямоугольник: " + "длина - " + leight.ToString() + ", ширина - " + width.ToString() + ", площадь - " + area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
