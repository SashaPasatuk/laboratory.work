using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._1
{
    delegate int MultiplicationOrDivision(int p1, int p2);
    class Program
    {
        static int Multiplication(int p1, int p2) { return p1 * p2; }
        static int Division(int p1, int p2) { return p1 / p2; }
        static void MultiplicationOrDivisionMethodFunc(string str, int i1, int i2, Func<int, int, int> MultiplicationOrDivisionParam)
        {
            int Result = MultiplicationOrDivisionParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void MultiplicationOrDivisionMethod(string str, int i1, int i2, MultiplicationOrDivision MultiplicationOrDivisionParam)
        {
            int Result = MultiplicationOrDivisionParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }
        static void Main(string[] args)
        {
            int i1 = 12;
            int i2 = 2;

            MultiplicationOrDivisionMethod("Умножение: ", i1, i2, Multiplication);
            MultiplicationOrDivisionMethod("Деление: ", i1, i2, Division);
            MultiplicationOrDivision pm1 = new MultiplicationOrDivision(Multiplication);
            MultiplicationOrDivisionMethod("Создание экземпляра делегата на основе метода: ", i1, i2, pm1);
            MultiplicationOrDivision pm2 = Multiplication;
            MultiplicationOrDivisionMethod("Создание экземпляра делегата на основе 'предположения' делегата: ", i1, i2, pm2);
            MultiplicationOrDivision pm3 = delegate(int param1, int param2)
            {
                return param1 + param2;
            };
            MultiplicationOrDivisionMethod("Создание экземпляра делегата на основе анонимного метода: ", i1, i2, pm2);
            MultiplicationOrDivisionMethod("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
                (int x, int y) =>
                {
                    int z = x * y;
                    return z;
                }
                );
            MultiplicationOrDivisionMethod("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
                (x, y) =>
                {
                    return x * y;
                }
                );
            MultiplicationOrDivisionMethod("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x * y);
            Console.WriteLine("\n\nИспользование обощенного делегата Func<>");
            MultiplicationOrDivisionMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Multiplication);
            string OuterString = "ВНЕШНЯЯ ПЕРЕМЕННАЯ";
            MultiplicationOrDivisionMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
                (int x, int y) =>
                {
                    Console.WriteLine("Эта переменная объявлена вне лямбда-выражения: " + OuterString);
                    int z = x * y;
                    return z;
                }
                );
            MultiplicationOrDivisionMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
                (x, y) =>
                {
                    return x * y;
                }
                );
            MultiplicationOrDivisionMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x * y);
            Console.WriteLine("Пример группового делегата");
            Action<int, int> a1 = (x, y) => { Console.WriteLine("{0} * {1} = {2}", x, y, x * y); };
            Action<int, int> a2 = (x, y) => { Console.WriteLine("{0} / {1} = {2}", x, y, x / y); };
            Action<int, int> group = a1 + a2;
            group(6, 3);
            Action<int, int> group2 = a1;
            Console.WriteLine("Добавление вызова метода к групповому делегату");
            group2 += a2;
            group2(10, 5);
            Console.WriteLine("Удаление вызова метода из группового делегата");
            group2 -= a1;
            group2(20, 10);
            Console.ReadLine();
        }
    }
}
