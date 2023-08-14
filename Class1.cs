namespace Area_figure
{
    public class Circle_Area
    {
        public double CalculateArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));
            }

            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }

    public class Triangle_Area
    {
        public double CalculateArea(double a, double b, double c)
        {
            double half_p = (a+b+c)/2;


            

            double area = Math.Sqrt((half_p*(half_p-a)*(half_p - b)*(half_p - c)));
            return area;
        }
    }


}