using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatingArea;

namespace CalculatingAreaTests
{
    [TestClass]
    public class TriangleTest
    {
        private Triangle figure;
        private double sideA;
        private double sideB;
        private double sideC;

        [TestMethod]
        public void FigureSquare_SizeOfThreeSidesOfTriangle_TriangleArea()
        {
            sideA = 3;
            sideB = 4;
            sideC = 5;
            figure = new Triangle(sideA, sideB, sideC);
            double expected = 6;
            double actual = figure.FigureArea();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void IsTriangleRightAngle_SizeOfThreeSidesOfTriangle_True()
        {
            sideA = 3;
            sideB = 4;
            sideC = 5;
            figure = new Triangle(sideA, sideB, sideC);
            Assert.IsTrue(figure.IsTriangleRightAngle());
        }

        [TestMethod]
        public void IsTriangleRightAngle_SizeOfThreeSidesOfTriangle_False()
        {
            sideA = 3;
            sideB = 3;
            sideC = 5;
            figure = new Triangle(sideA, sideB, sideC);
            Assert.IsFalse(figure.IsTriangleRightAngle());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FigureArea_InvalidValues_Exception()
        {
            sideA = 3;
            sideB = 0;
            sideC = 5;
            figure = new Triangle(sideA, sideB, sideC);
            figure.FigureArea();
        }
    }
}
