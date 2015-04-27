using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public class WhiteGoods: IWhiteGoods
    {
        public string NameProduction { get; set; }
        public DateTime DateProduction { get; set; }
        public double Price { get; set; }
        public ClassEnergy ClassEnergy { get; set; }
    }
}
