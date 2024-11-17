using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbercheck
{
    internal class Datecheck
    {
        public delegate void TimeDelegate();
        public delegate double AreaDelegate(double a, double b);
        static void CurrentTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
        static void CurrentDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
        }
        static void CurrentDayOfWeek()
        {
            Console.WriteLine(DateTime.Now.ToString("dddd"));
        }
        static double Triangle(double length, double height)
        {
            return 0.5 * length * height;
        }
        static double Rectangle(double width, double height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            TimeDelegate showTime = CurrentTime;
            TimeDelegate showDate = CurrentDate;
            TimeDelegate showDayOfWeek = CurrentDayOfWeek;
            Console.WriteLine("Время сейчас:");
            showTime();
            Console.WriteLine("Дата сегодня:");
            showDate();
            Console.WriteLine("День недели:");
            showDayOfWeek();
            AreaDelegate triangle = Triangle;
            AreaDelegate rectangle = Rectangle;
            double lengthTriangle = 5;
            double heightTriangle = 10;
            Console.WriteLine($"Площадь треугольника с основанием {lengthTriangle} и высотой {heightTriangle}: {triangle(lengthTriangle, heightTriangle)}");
            double widthRectangle = 4;
            double heightRectangle = 8;
            Console.WriteLine($"Площадь прямоугольника с шириной {widthRectangle} и высотой {heightRectangle}: {rectangle(widthRectangle, heightRectangle)}");
        }

      
    }
}
