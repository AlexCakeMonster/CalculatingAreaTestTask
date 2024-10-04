using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea
{
    public class UnknownFigure
    {
        public double FigureArea(double radius)
        {
            var figure = new Circle(radius);
            Console.WriteLine("The figure is a Circle");
            return figure.FigureArea();
        }

        public double FigureArea(double sideA, double sideB, double sideC)
        {
            var figure = new Triangle(sideA, sideB, sideC);
            Console.WriteLine("The figure is a Triangle");
            return figure.FigureArea();
        }
    }
}
