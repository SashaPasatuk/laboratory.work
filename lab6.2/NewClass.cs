using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    class NewClass
    {
        public NewClass() { }
        public NewClass(int i) { }
        public int Multiplication(int x, int y) { return x * y; }
        public int Division(int x, int y) { return x / y; }
        public int a;
        public float b;
        [NewAttribute("Описание для property1")]
        public string property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }
        private string _property1;
        public int property2 { get; set; }
        [NewAttribute(Description = "Описание для property3")]
        public double property3 { get; private set; }  
    }
}
