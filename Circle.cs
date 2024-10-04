using System;

namespace CalculatingArea
{
    public class Circle : Figure
    {
        private double Radius { get; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The values ​​passed must be greater than zero.");
            this.Radius = radius;
        }
        public override double FigureArea()
        {
            return  Math.PI * Math.Pow(Radius, 2);
        }
    }
}
