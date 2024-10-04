using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatingArea;

namespace CalculatingAreaTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void FigureArea_Radius_CircleArea()
        {
            double radius = 4;
            double expected = 50.27;

            Figure figure = new Circle(radius);
            double actual = Math.Round(figure.FigureArea(), 2);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FigureArea_InvalidValues_Exception()
        {
            double radius = 0;
            Figure figure = new Circle(radius);
            figure.FigureArea();
        }
    }
}
