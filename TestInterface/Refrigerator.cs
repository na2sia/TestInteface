using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
   public class Refrigerator:WhiteGoods,IRefrigerator
    {
        public TypeControl TypeControl { get; set; }
        public TypeDesign TypeDesign { get; set; }
    }
}
