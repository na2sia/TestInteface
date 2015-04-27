using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
   public class TV: WhiteGoods, ITV
    {
       public ScreenType ScreenType { get; set; }
       public int ScreenSize { get; set; }
       public HDFormat HDFormat { get; set; }
    }
}
