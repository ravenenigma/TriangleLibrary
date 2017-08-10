using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;

namespace TriangleUnitTest
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// проверка на кооректность заданных сторон треугольника
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WrongSideLengthTest()
        {
            Triangle t = new Triangle(1, 2, 0);
        }

        /// <summary>
        /// Проверка условия неравенства треугольника
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleInequalityTest()
        {
            Triangle t = new Triangle(2, 3, 6);
        }

        /// <summary>
        /// Вычесление площадь треугольника
        /// </summary>
        [TestMethod]
        public void AreaTest()
        {
            Triangle t = new Triangle(3, 4, 5);

            const double expected = 3 * 4 / 2;
            double area = t.Area();

            Assert.AreEqual(expected, area, 1E-3);
        }
    }

    /// <summary>
    /// Проверка прямоугольного треугольника
    /// </summary>
    [TestClass]
    public class RightTriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NotRightTriangleTest()
        {
            RightTriangle t = new RightTriangle(1, 2, 3);
        }

        [TestMethod]
        public void CorrectRightTriangleTest()
        {
            RightTriangle t = new RightTriangle(3, 4, 5);
        }
    }
}
