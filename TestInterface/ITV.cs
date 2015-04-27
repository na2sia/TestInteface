using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public interface ITV: IWhiteGoods
    {
        ScreenType ScreenType { get; }
        int ScreenSize { get; }
        HDFormat HDFormat { get; }

    }
}
