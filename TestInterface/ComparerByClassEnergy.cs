using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    class ComparerByClassEnergy:IComparer<IWhiteGoods>
    {
        public int Compare(IWhiteGoods x, IWhiteGoods y)
        {
            return x == null ? 1 : x.ClassEnergy.CompareTo(y.ClassEnergy);
           /* if (x != null && y != null)
            {
                if (x.ClassEnergy > y.ClassEnergy)
                    return 1;
                if (x.ClassEnergy < y.ClassEnergy)
                    return -1;
                else return 0;
            }
            else return -1;*/
        }
    }

}
