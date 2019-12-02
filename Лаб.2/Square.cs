using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб._2
{
    class Square : Rectangle, IPrint
    {
        public double leigth { get; set; }
        public Square(double a)
            : base(a)
        {
            leight = a;
            Area = area();
        }
        public Square()
            : base()
        {
            Area = area();
        }
        public override string ToString()
        {
            return "Фигура квадрат: " + "длина - " + leight.ToString() + ", площадь - " + area().ToString();
        }
    }
}
