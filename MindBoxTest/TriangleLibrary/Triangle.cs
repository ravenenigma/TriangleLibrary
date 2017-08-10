using System;

namespace TriangleLibrary
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            //проверка на кооректность заданных сторон треугольника
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                throw new ArgumentOutOfRangeException("The triangle sides are incorrectly set!");
            }
            //Проверка условия неравенства треугольника
            if (!((a + b >= c) && (a + c >= b) && (b + c >= a)))
            {
                throw new ArgumentOutOfRangeException("The condition of inequality of a triangle is satisfied!");
            }

            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Вычесление площадь треугольника по 3 сторонам
        /// по Формуле Герона S=sqrt(p*(p-a)*(p-b)*(p-c))
        /// </summary>
        /// <returns>площадь треугольника по 3 сторонам</returns>
        public double Area()
        {
            double p = (A + B + C) / 2;     //Полупериметр треугольника
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));      //Формула Герона для вычесления площади треугольника
        }
    }

    /// <summary>
    /// Проверка прямоугольного треугольника по теореме Пифагора
    /// </summary>
    public class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, double c) : base(a, b, c)
        {
            if (Math.Abs(a * a + b * b - c * c) > 1E-6)     //теорема Пифагора
            {
                throw new ArgumentOutOfRangeException("Isn't a right triangle!");
            }
        }
    }
}
