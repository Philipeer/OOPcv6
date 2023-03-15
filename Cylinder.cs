using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Cylinder : Object3D
    {
        private double radius { get; set; }
        private double height { get; set; }
        public Cylinder(double valR, double valH)
        {
            try
            {
                if (valR < 0 || valH < 0)
                {
                    throw new ArgumentException("Radius or height of cylinder can not be smaller than 0!!!");
                }
                else
                {
                    radius = valR;
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
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius,2);
        }

        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Cylinder(Radius: {radius}, Height: {height}, Surface: {CalculateSurface()}, Volume: {CalculateVolume()})");
        }
    }
}
