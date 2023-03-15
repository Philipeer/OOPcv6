using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV6
{
    /*public interface IObjects 
    {
        void Draw();
    }*/
    public abstract class GrObject //základní třída, potomci budou implementovat metodu Draw
    {
        public abstract void Draw();
    }
}
