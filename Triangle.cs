using System;

namespace CalculatingArea
{
    public class Triangle : Figure
    {
        private double SideA { get;}
        private double SideB { get;}
        private double SideC { get;}

        private double triangleArea;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("The values ​​passed must be greater than zero.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double FigureArea()
        {
            double semiperimeter = (SideA + SideB + SideC) / 2;
            triangleArea = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
            return triangleArea;
        }

        public bool IsTriangleRightAngle()
        {
            double maxSide = Math.Max(SideA, Math.Max(SideB, SideC));

            if (maxSide == SideA)
            {
                return Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
            }
            else if (maxSide == SideB)
            {
                return Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2);
            }
            else
            {
                return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2);
            }
        }
    }
}
