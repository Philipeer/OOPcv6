using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Triangle : Object2D
    {
        private double side { get; set; }
        private double height { get; set; }
        public Triangle(double valS, double valH)
        {
            try
            {
                if (valS < 0 || valH < 0)
                {
                    throw new ArgumentException("Side or height of triangle can not be smaller than 0!!!");
                }
                else
                {
                    side = valS;
                    height = valH;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public override double CalculateSurface()
        {
            return (side*height)/2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Triangle(Side: {side}, Height: {height}, Surface: {CalculateSurface()})");
        }
    }
}
