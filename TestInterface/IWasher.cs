using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public interface IWasher: IWhiteGoods
    {
        TypeWasher TypeWasher { get; }
        int MaxLoad { get; }
        int MaxSpinSpeed { get; }
        TypeLoad TypeLoad { get; }

    }
}
