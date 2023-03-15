using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public class Block : Object3D
    {
        private double sideA { get; set; } //gettery settery, vnitřní proměnné, proto s malými písmeny
        private double sideB { get; set; }
        private double sideC { get; set; }
        public Block(double valA, double valB, double valC) //konstruktor s parametry stran
        {
            try
            {
                if (valA < 0 || valB < 0 || valC < 0)
                {
                    throw new ArgumentException("Sides of block can not be smaller than 0!!!");
                }
                else
                {
                    sideA = valA;
                    sideB = valB;
                    sideC = valC;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public override double CalculateSurface() //přetížené metody, které potomoci museli implementovat po rodičích, to stejné u ostatních tříd
        {
            return 2 * (sideA * sideB) + 2 * (sideA * sideC) + 2 * (sideB * sideC);
        }

        public override double CalculateVolume()
        {
            return sideA * sideB * sideC;
        }

        public override void Draw()
        {
            Console.WriteLine($"Block(Side A: {sideA}, Side B: {sideB}, Side C: {sideC}, Surface: {CalculateSurface()}, Volume: {CalculateVolume()})");
        }
    }
}
