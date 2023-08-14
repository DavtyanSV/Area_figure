using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area_figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Area_figure.Tests
{
    public class FigureCalculatorTests
    {

        public void TestCalculateCircleArea()
        {
            FigureCalculator calculator = new FigureCalculator();
            double radius = 5.0;
            double expectedArea = Math.PI * radius * radius;

            double actualArea = calculator.CalculateAreaCircle(radius);

            Assert.AreEqual(expectedArea, actualArea);
        }

        public void TestCalculateTriangleArea()
        {
            FigureCalculator calculator = new FigureCalculator();
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;
            double expectedArea = 6.0; 

            double actualArea = calculator.CalculateAreaTriangle(side1, side2, side3);

            Assert.AreEqual(expectedArea, actualArea);
        }

        public void TestCalculateUnknownShapeArea()
        {
            FigureCalculator calculator = new FigureCalculator();
            double[] sides = { 3.0, 4.0, 5.0 };
            double expectedArea = 6.0; 

            double actualArea = calculator.CalculateUnknownShapeArea(sides);

            Assert.AreEqual(expectedArea, actualArea);
        }

        public void TestIsRightTriangle()
        {
            FigureCalculator calculator = new FigureCalculator();
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0;

            bool isRightTriangle = calculator.IsRightTriangle(side1, side2, side3);

            Assert.IsTrue(isRightTriangle);
        }




    }

   
}
