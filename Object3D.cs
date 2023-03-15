using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    public abstract class Object3D : GrObject //to stejné jak Object2D jen o metodu navíc pro implementaci
    {
        public abstract double CalculateSurface();
        public abstract double CalculateVolume();
    }
}
