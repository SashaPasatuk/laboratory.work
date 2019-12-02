using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пасатюк Александра ИУ5-33Б";
            double a, b, c, d;
            Console.WriteLine("Введите значения длинны и ширины прямоугольника: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверное значение, повторите ввод!");
                Console.ResetColor();
            }
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверное значение, повторите ввод!");
                Console.ResetColor();
            }
            Rectangle A = new Rectangle(a, b);
            Console.WriteLine("Введите значения длинны квадрата: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверное значение, повторите ввод!");
                Console.ResetColor();
            }
            Square B = new Square(c);
            Console.WriteLine("Введите значения радиуса круга: ");
            while (!double.TryParse(Console.ReadLine(), out d))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверное значение, повторите ввод!");
                Console.ResetColor();
            }
            Circle C = new Circle(d);
            A.Print();
            B.Print();
            C.Print();
            Console.ReadKey();
        }
    }
}
