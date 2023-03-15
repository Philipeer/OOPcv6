using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Sphere : Object3D
    {
        private double radius { get; set; }
        public Sphere(double value)
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius of sphere can not be smaller than 0!!!");
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
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public override double CalculateVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }

        public override void Draw()
        {
            Console.WriteLine($"Sphere(Radius: {radius}, Surface: {CalculateSurface()}, Volume: {CalculateVolume()})");
        }
    }
}
