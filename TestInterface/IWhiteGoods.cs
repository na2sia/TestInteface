using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    public interface IWhiteGoods

    {
        string NameProduction { get; }
        DateTime DateProduction { get; }
        double Price { get; }
        ClassEnergy ClassEnergy { get; }

    }
}
