using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пасатюк Александра ИУ5-33Б";
            double a = 0, b = 0, c = 0;
            if (args.Length == 3)
            {

                if (!double.TryParse(args[0], out a) || !double.TryParse(args[1], out b) || !double.TryParse(args[2], out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода!");
                    Console.ResetColor();
                }
                else
                {
                    double.TryParse(args[0], out a);
                    double.TryParse(args[1], out b);
                    double.TryParse(args[2], out c);
                    Console.WriteLine("A={0}, B={1}, C={2}", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("Введите коэффициенты А, В и С биквадратного уравнения Ax^4+Bx^2+C=0:");
                Console.Write("Введите коэффициент А: ");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент А введен неверно, повторите ввод!");
                    Console.ResetColor();
                }
                Console.Write("Введите коэффициент B: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент B введен неверно, повторите ввод!");
                    Console.ResetColor();
                }
                Console.Write("Введите коэффициент C: ");
                while (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент C введен неверно, повторите ввод!");
                    Console.ResetColor();
                }
                Console.WriteLine("Вы ввели A={0}, B={1}, C={2}", a, b, c);
                if (a == 0 && b == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициенты А и В введены некорректно, так как не могут быть обя равны 0.");
                    Console.WriteLine("Введите коэффициенты А и В снова: ");
                    Console.ResetColor();
                    while (!double.TryParse(Console.ReadLine(), out a))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Коэффициент А введен неверно, повторите ввод!");
                        Console.ResetColor();
                    }
                    while (!double.TryParse(Console.ReadLine(), out b))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Коэффициент B введен неверно, повторите ввод!");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Вы ввели: A={0}, B={1}, C={2}", a, b, c);
                }

            }
            Console.WriteLine("Корни уравнения: ");
            if (a == 0 & b != 0)
            {
                double v = -c / b;
                if (v < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Корней нет, так как дискриминант меньше 0");
                    Console.ResetColor();
                }
                else
                {
                    if (v == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("x=0");
                        Console.ResetColor();
                    }
                    else
                    {
                        double x1 = Math.Sqrt(v);
                        double x2 = (-1) * Math.Sqrt(v);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("x1={0}, x2={1}", x1, x2);
                        Console.ResetColor();
                    }
                }
            }
            if (a != 0 & b == 0)
            {
                double v = -c / a;
                if (v < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Корней нет, так как дискриминант меньше 0");
                    Console.ResetColor();
                }
                else
                {
                    if (v == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("x=0");
                        Console.ResetColor();
                    }
                    else
                    {
                        double x1 = Math.Pow(v, 1 / 4.0);
                        double x2 = (-1) * Math.Pow(v, 1 / 4.0);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("x1={0}, x2={1}", x1, x2);
                        Console.ResetColor();
                    }
                }
            }
            if (c == 0 & a != 0 & b != 0)
            {
                double v = (-1) * b / a;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("x1=0");
                Console.ResetColor();
                if (v > 0)
                {
                    double x2 = Math.Pow(v, 1 / 4.0);
                    double x3 = (-1) * Math.Pow(v, 1 / 4.0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("x1=0, x2={0}, x3={1}", x2, x3);
                    Console.ResetColor();
                }
            }
            if (a != 0 & b != 0 & c != 0)
            {
                double d = b * b - 4 * a * c;
                if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Корней нет, так как дискриминант меньше 0");
                    Console.ResetColor();
                }
                else
                {
                    if (d == 0)
                    {
                        double t1 = ((-1) * b + Math.Sqrt(d)) / (2 * a);
                    }
                    else
                    {
                        double t1 = ((-1) * b + Math.Sqrt(d)) / (2 * a);
                        double t2 = ((-1) * b - Math.Sqrt(d)) / (2 * a);
                        if (t1 < 0 & t2 < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Корней нет");
                            Console.ResetColor();
                        }
                        else
                        {
                            if (t2 == 0 | t1 == 0)
                            {
                                double x2 = 0, x3 = 0;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("x1=0,");
                                Console.ResetColor();
                                if (t2 != 0)
                                {
                                    x2 = Math.Sqrt(t2);
                                    x3 = (-1) * Math.Sqrt(t2);
                                }
                                if (t1 != 0)
                                {
                                    x2 = Math.Sqrt(t1);
                                    x3 = (-1) * Math.Sqrt(t1);
                                }
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("x2={0}, x3={1}", x2, x3);
                                Console.ResetColor();

                            }
                            else
                            {
                                int n = 1;
                                double x1, x2, x3 = 0, x4;
                                if (t1 > 0)
                                {
                                    x1 = Math.Sqrt(t1);
                                    x2 = (-1) * Math.Sqrt(t1);
                                    n++;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("x{1}={0}", x1, n - 1);
                                    Console.WriteLine("x{1}={0}", x2, n);
                                    Console.ResetColor();
                                    n++;
                                }
                                if (t2 > 0)
                                {
                                    x3 = Math.Sqrt(t2);
                                    x4 = (-1) * Math.Sqrt(t2);
                                    n++;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("x{1}={0}", x3, n - 1);
                                    Console.WriteLine("x{1}={0}", x4, n);
                                    Console.ResetColor();
                                }
                            }
                        }

                    }
                }
            }
            Console.ReadKey();           
        }
    }
}
