using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб._2
{
    public abstract class Figure : IComparable
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;
        public double Area;
        public abstract double area();
        public override string ToString()
        {
            return this.Type + "площадью" + this.area().ToString();
        }
        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;
            if (this.area() < p.area()) return -1;
            else if (this.area() == p.area()) return 0;
            else return 1;
        }
    }
}
