namespace Area_figure
{

    public class FigureCalculator
    {
        
        public double CalculateAreaCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));
            }

            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double CalculateUnknownShapeArea(double[] sides)
        {
            if (sides.Length != 3)
            {
                throw new ArgumentException("Должно быть передано три стороны для вычисления площади треугольника.");
            }

            double semiPerimeter = sides.Sum() / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
            return area;
        }
        public double CalculateAreaTriangle(double a, double b, double c)
        {
            double half_p = (a+b+c)/2;


            

            double area = Math.Sqrt((half_p*(half_p-a)*(half_p - b)*(half_p - c)));
            return area;
        }

        public bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }


}