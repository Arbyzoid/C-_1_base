using System;

namespace C_2_base
{
    // Необходимо реализовать объектную модель геометрических фигур (прямоугольник, тругольник, круг).
    // Ко всем фигурам должно быть возможно осуществить доступ по одному имени 
    // Через это имя должно быть возможно получить доступ к площади и периметру фигур
    // Все числа пусть имееют тип double

    public interface Figure
    {
        double Perimeter
        {
            get;
        }

        double Square
        {
            get;
        }
    }

    public class Triangle : Figure
    {
        double side1, side2, side3, height;

        public Triangle(double x, double y, double z, double h)
        { 
            side1 = x;
            side2 = y;
            side3 = z;
            height = h;
        }

        public double Perimeter
        {
            get
            {
                return side1 + side2 + side3;
            }
        }

        public double Square
        {
            get
            {
                return side1 * height / 2;
            }
        }
    }

    public class Rectangle : Figure
    {
        double width, height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public double Perimeter
        {
            get
            {
                return (width + height) * 2;
            }
        }

        public double Square
        {
            get
            {
                return width * height;
            }
        }

        public class Сircle : Figure
        {
            double diameter;

            public Сircle(double d)
            {
                diameter = d;
            }

            public double Perimeter
            {
                get
                {
                    return diameter * 3.14;
                }
            }

            public double Square
            {
                get
                {
                    return (diameter / 2) * (diameter / 2) * 3.14;
                }
            }

        }
    }



}