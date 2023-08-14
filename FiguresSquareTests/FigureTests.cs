using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresSquare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresSquare.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void Square_Circle_Test()
        {
            // Arrange
            int radius = 5;
            double exprcted = Math.PI * radius * radius;

            // Actual
            Figure circle = new Circle(radius);
            double actual = circle.Square();

            // Assert
            Assert.AreEqual(exprcted, actual);
        }

        [TestMethod()]
        public void Square_Triangle_Test()
        {
            // Arrange
            int a = 3, b = 4, c = 5;
            double p = (a + b + c) / 2;
            double exprcted = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Actual
            Figure triangle = new Triangle(a, b, c);
            double actual = triangle.Square();

            // Assert
            Assert.AreEqual(exprcted, actual);
        }

        [TestMethod()]
        public void IsRight_Triangle_Test()
        {
            // Arrange
            int a = 3, b = 4, c = 5;
            bool exprcted = true;

            // Actual
            Figure triangle = new Triangle(a, b, c);
            bool actual = ((Triangle)triangle).isRight;

            // Assert
            Assert.AreEqual(exprcted, actual);
        }
    }
}