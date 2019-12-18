using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Лаб._2;

namespace lab3
{
    class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(6, 2);
            Square square = new Square(4);
            Circle circle = new Circle(2);

            Console.Write("\nList:");
            List<Figure> l2 = new List<Figure>();
            l2.Add(circle);
            l2.Add(rect);
            l2.Add(square);
            Console.WriteLine("\nПеред сортировкой:");
            foreach (object i in l2) Console.Write(i.ToString() + " ");
            l2.Sort();
            Console.WriteLine("\nПосле сортировки:");
            foreach (object i in l2) Console.Write(i.ToString() + " ");
            Console.WriteLine("");

            Console.WriteLine("\nМатрица");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = square;
            matrix[2, 2, 2] = circle;
            Console.WriteLine(matrix.ToString());
            Console.ReadKey();

            Console.WriteLine("Стек");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }

        }
    }
}
