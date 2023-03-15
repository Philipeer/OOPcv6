using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Pyramid : Object3D
    {
        private double baseArea { get; set; }
        private double shellArea { get; set; }
        private double height { get; set; }
        public Pyramid(double valB, double valS, double valH)
        {
            try
            {
                if (valB < 0 || valS < 0 || valH < 0)
                {
                    throw new ArgumentException("Height, area of base or area of shell of pyramid can not be smaller than 0!!!");
                }
                else
                {
                    baseArea = valB;
                    shellArea = valS;
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
            return baseArea + shellArea; 
        }

        public override double CalculateVolume()
        {
            return baseArea * height * (1 / 3);
        }

        public override void Draw()
        {
            Console.WriteLine($"Pyramid(Area of base: {baseArea}, Area of shell: {shellArea}, Height: {height}, Surface: {CalculateSurface()}, Volume: {CalculateVolume()})");
        }
    }
}
