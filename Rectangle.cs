using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Rectangle : Object2D
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        public Rectangle(double valA, double valB) 
        {
            try 
            {
                if (valA < 0 || valB < 0)
                {
                    throw new ArgumentException("Sides of rectangle can not be smaller than 0!!!");
                }
                else 
                {
                    sideA = valA;
                    sideB = valB;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
        }
        public override double CalculateSurface()
        {
            return sideA * sideB;
        }

        public override void Draw()
        {
            Console.WriteLine($"Rectangle(Side A: {sideA}, Side B: {sideB}, Surface: {CalculateSurface()})");
        }
    }
}
