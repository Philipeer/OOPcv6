using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public abstract class Object2D : GrObject //třída jenž dědí z GrObject, potomci budou implementovat metodu VypocitejPlochu a Kresli
    {
        public abstract double CalculateSurface();
    }
}
