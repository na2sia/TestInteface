using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public class Washer:WhiteGoods,IWasher
    {
        public TypeWasher TypeWasher { get; set; }
        public int MaxLoad { get; set; }
        public int MaxSpinSpeed { get; set; }
        public TypeLoad TypeLoad { get; set; }
    }
}
