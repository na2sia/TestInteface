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
            if (x != null && y != null)
            {
                if (x.DateProduction > y.DateProduction)
                {
                    return 1;
                }
                else
                {
                    return (x.DateProduction == y.DateProduction) ? 0 : -1;
                }
            }
            else
            {
                return (y == null && x == null) ? 0 : (x != null) ? 1 : -1;
            }
        }
    }
}
