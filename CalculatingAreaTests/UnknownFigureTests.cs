using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatingArea;

namespace CalculatingAreaTests
{
    [TestClass]
    public class UnknownFigureTests
    {
        [TestMethod]
        public void FigureSquare_OneArgument_CircleArea()
        {
            double radius = 4;
            double expected = 50.27;

            var figure = new UnknownFigure();
            double actual = Math.Round(figure.FigureArea(radius), 2);

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void FigureSquare_ThreeArguments_triangleArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expected = 6;

            var figure = new UnknownFigure();
            double actual = figure.FigureArea(sideA, sideB, sideC);

            Assert.AreEqual(actual, expected);
        }
    }
}
