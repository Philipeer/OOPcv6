using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Ellipse : Object2D
    {
        private double halfaxisA { get; set; }
        private double halfaxisB { get; set; }
        public Ellipse(double valA, double valB)
        {
            try
            {
                if (valA < 0 || valB < 0)
                {
                    throw new ArgumentException("Halfaxis of ellipse can not be smaller than 0!!!");
                }
                else
                {
                    halfaxisA = valA;
                    halfaxisB = valB;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public override double CalculateSurface()
        {
            return Math.PI * halfaxisA * halfaxisB;
        }

        public override void Draw()
        {
            Console.WriteLine($"Ellipse(Halfaxis A: {halfaxisA}, Halfaxis B: {halfaxisB}, Surface: {CalculateSurface()})");
        }
    }
}
