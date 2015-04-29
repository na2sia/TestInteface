using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public class ComparerByYearP : IComparer<IWhiteGoods>
    {
        public int Compare(IWhiteGoods x, IWhiteGoods y)
        {
            return x == null ? 1 : x.DateProduction.CompareTo(y.DateProduction);
           /* if (x != null && y != null)
            {
                if (x.DateProduction > y.DateProduction)
                    return 1;
                if (x.DateProduction < y.DateProduction)
                    return -1;
                else return 0;
            }
            else return -1;*/
        }
    }
}
