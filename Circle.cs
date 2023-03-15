using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Circle : Object2D
    {
        private double radius{ get; set; }
        public Circle(double value)
        {
            try 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius of circle can not be smaller than 0!!!");
                }
                else
                {
                    radius = value;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(radius,2);
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle(Radius: {radius}, Surface: {CalculateSurface()})");
        }
    }
}
